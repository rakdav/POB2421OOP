using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson17
{
    public partial class FormAtricles : Form
    {
        private ArticlesHandler handler;
        public FormAtricles()
        {
            InitializeComponent();
            handler=new ArticlesHandler();
            if (UserAuthentification.RegisterUser!.Role == "Читатель")
            {
                buttonAdd.Visible = false;
                buttonDel.Visible = false;
            }
        }

        private void FormAtricles_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAutorization.instance!.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormArticle formArticle = new FormArticle();
            if(formArticle.ShowDialog()==DialogResult.OK)
            {
                Article article = new Article();
                article.Theme = formArticle.textBoxTheme.Text;
                article.Author = formArticle.textBoxAuthor.Text;
                article.Age=(int)formArticle.numericUpDownAge.Value;
                article.Title=formArticle.textBoxArticle.Text;
                article.Content=formArticle.richTextBox1.Text;
                handler.Add(article);
                listBoxArticles.Items.Clear();
                List<Article> list = handler.getArticles();
                for (int i = 0; i < list.Count; i++)
                {
                    listBoxArticles.Items.Add(list[i].Title+" " + list[i].Author);
                }
            }
        }
    }
}
