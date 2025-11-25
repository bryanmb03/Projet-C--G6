using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestion.Models
{
    namespace AppGestion.Models
    {
        public class Livre : Article
        {
            public string Auteur { get; private set; }

            public Livre(string nom, decimal prix, string auteur)
                : base(nom, prix)
            {
                Auteur = auteur;
            }

            public override string AfficherDetails()
            {
                return $"Livre: {Nom}, Auteur: {Auteur}, Prix: {Prix}€";
            }
        }
    }

}
