using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPIRE
{
    public partial class Form1 : Form
    {
        private Inventaire<Article> inventaire;

        public Form1()
        {
            InitializeComponent();
            InitialiserInventaire();
            MettreAJourListe();
        }

        private void InitialiserInventaire()
        {
            inventaire = new Inventaire<Article>();
            inventaire.Ajouter(new Livre("Le Seigneur des Anneaux", 20m, "Tolkien", 2));
            inventaire.Ajouter(new Electronique("iPhone", 999m, 24, 0));
        }

        private void MettreAJourListe()
        {
            listBoxArticles.Items.Clear();
            var articles = inventaire.ObtenirArticles();
            foreach (var art in articles)
            {
                string etat = art.Quantite > 0 ? $"({art.Quantite} en stock)" : "(RUPTURE)";
                listBoxArticles.Items.Add($"{art.Nom} - {art.Prix}€ {etat}");
            }
        }

        private void buttonAcheter_Click(object sender, EventArgs e)
        {
            if (listBoxArticles.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un article.");
                return;
            }

            string client = textBoxClient.Text.Trim();
            if (string.IsNullOrEmpty(client))
            {
                MessageBox.Show("Veuillez entrer votre nom.");
                return;
            }

            Article article = inventaire.ObtenirArticle(listBoxArticles.SelectedIndex);

            if (article.Quantite > 0)
            {
                article.Quantite--;
                MessageBox.Show("✅ Achat réussi !");
            }
            else
            {
                if (MessageBox.Show($"\"{article.Nom}\" est en rupture.\nMettre {client} en attente ?", "Rupture", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    article.FileAttente.Add(client);
                    MessageBox.Show("✅ Vous êtes en attente.");
                }
            }

            MettreAJourListe();
        }

        private void buttonVoirAttente_Click(object sender, EventArgs e)
        {
            if (listBoxArticles.SelectedIndex == -1) return;

            Article article = inventaire.ObtenirArticle(listBoxArticles.SelectedIndex);
            if (article.FileAttente.Count == 0)
                MessageBox.Show($"Aucun client en attente pour \"{article.Nom}\".");
            else
                MessageBox.Show("Clients en attente :\n- " + string.Join("\n- ", article.FileAttente));
        }
    }
}
