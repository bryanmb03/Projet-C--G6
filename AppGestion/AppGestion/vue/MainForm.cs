using AppGestion.Models;
using AppGestion.Models.AppGestion.Models;
using AppGestion.Services;
using System;
using System.Windows.Forms;

namespace AppGestion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string connStr = "server=localhost;user=root;password=tonmdp;database=gestionstock;";
            var dbService = new DatabaseService(connStr);
            dbService.TestConnection();
        }

        private void btnListerStock_Click(object sender, EventArgs e)
        {
            var inventaire = new Inventaire<Article>();

            
            var livre = new Livre("Le Seigneur des Anneaux", 20m, "Tolkien");
            var iphone = new Electronique("iPhone", 999m, 24);

            
            inventaire.Ajouter(livre);
            inventaire.Ajouter(iphone);

            string message = string.Join("\n", inventaire.ListerStock());
            MessageBox.Show(message, "Stock actuel");
        }
    }
}
