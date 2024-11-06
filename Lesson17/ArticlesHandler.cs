using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class ArticlesHandler
    {
        private List<Article>? articles;

        public ArticlesHandler()
        {
            this.articles = new List<Article>();
        }
        public void Add(Article article)
        {
            articles!.Add(article);
        }
        public void Remove(Article article)
        {
            articles!.Remove(article);
        }
        public List<Article> getArticles() => articles!;
        public Article getArticle(int index) => articles![index];
    }
}
