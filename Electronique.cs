using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPIRE
{
    public class Electronique : Article
    {
        public int GarantieMois { get; private set; }

        public Electronique(string nom, decimal prix, int garantieMois, int quantite = 0)
            : base(nom, prix, quantite)
        {
            GarantieMois = garantieMois;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Electro: {Nom}, Garantie: {GarantieMois} mois, Prix: {Prix}€");
        }
    }
}
