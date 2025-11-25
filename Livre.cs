using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPIRE
{
    public class Livre : Article
    {
        public string Auteur { get; private set; }

        public Livre(string nom, decimal prix, string auteur, int quantite = 0)
            : base(nom, prix, quantite)
        {
            Auteur = auteur;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Livre: {Nom}, Auteur: {Auteur}, Prix: {Prix}€");
        }
    }
}
