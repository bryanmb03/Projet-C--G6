using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestion.Models
{
    namespace AppGestion.Models
    {
        public class Electronique : Article
        {
            public int GarantieMois { get; private set; }

            public Electronique(string nom, decimal prix, int garantieMois)
                : base(nom, prix)
            {
                GarantieMois = garantieMois;
            }

            public override string AfficherDetails()
            {
                return $"Electro: {Nom}, Garantie: {GarantieMois} mois, Prix: {Prix}€";
            }
        }
    }

}
