using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPIRE
{

    public abstract class Article
    {
        public string Nom { get; private set; }
        public decimal Prix { get; private set; }
        public int Quantite { get; set; }
        public List<string> FileAttente { get; private set; } = new List<string>();

        public Article(string nom, decimal prix, int quantite = 0)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }

        public abstract void AfficherDetails();
    }
}
