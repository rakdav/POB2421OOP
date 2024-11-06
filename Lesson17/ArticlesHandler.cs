using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            string path = "article.json";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                string json = JsonSerializer.Serialize(articles);
                writer.WriteLine(json);
            }
        }
        public void Remove(Article article)
        {
            articles!.Remove(article);
        }
        public List<Article> getArticles() => articles!;
        public Article getArticle(int index) => articles![index];
        public void ReadArticles()
        {
            string path = "article.json";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if(text!="")
                    articles = JsonSerializer.Deserialize<List<Article>>(text);
            }
        }
    }
}
