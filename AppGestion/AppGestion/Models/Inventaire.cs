using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestion.Models
{
    using System.Collections.Generic;

    namespace AppGestion.Models
    {
        public class Inventaire<T> where T : Article
        {
            private List<T> _articles = new List<T>();

            public void Ajouter(T article)
            {
                _articles.Add(article);
            }

            public List<string> ListerStock()
            {
                List<string> details = new List<string>();
                foreach (var article in _articles)
                {
                    details.Add(article.AfficherDetails());
                }
                return details;
            }
        }
    }

}
