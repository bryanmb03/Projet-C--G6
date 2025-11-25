using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPIRE
{
   
    public class Inventaire<T> where T : Article
    {
        private List<T> _listeArticles = new List<T>();

        public void Ajouter(T article)
        {
            _listeArticles.Add(article);
        }

        public void ListerStock()
        {
            foreach (var article in _listeArticles)
            {
                article.AfficherDetails();
            }
        }

        // Nouvelles méthodes pour WinForms
        public List<T> ObtenirArticles() => new List<T>(_listeArticles);

        public T ObtenirArticle(int index) => _listeArticles[index];
    }
}
