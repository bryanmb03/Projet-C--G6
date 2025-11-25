using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestion.Models
{
    namespace AppGestion.Models
    {
        public abstract class Article
        {
            public string Nom { get; private set; }
            public decimal Prix { get; private set; }

            protected Article(string nom, decimal prix)
            {
                Nom = nom;
                Prix = prix;
            }

            public abstract string AfficherDetails();
        }
    }

}
