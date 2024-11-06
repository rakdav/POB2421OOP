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
            handler = new ArticlesHandler();
            if (UserAuthentification.RegisterUser!.Role == "Читатель")
            {
                buttonAdd.Visible = false;
                buttonDel.Visible = false;
                buttonEdit.Visible = false;
            }
            handler.ReadArticles();
            UpdateList();
        }

        private void FormAtricles_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserAuthentification.ExitUesr();
            FormAutorization.instance!.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormArticle formArticle = new FormArticle();
            if (formArticle.ShowDialog() == DialogResult.OK)
            {
                Article article = new Article();
                article.Theme = formArticle.textBoxTheme.Text;
                article.Author = formArticle.textBoxAuthor.Text;
                article.Age = (int)formArticle.numericUpDownAge.Value;
                article.Title = formArticle.textBoxArticle.Text;
                article.Content = formArticle.richTextBox1.Text;
                handler.Add(article);
                UpdateList();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxArticles.SelectedIndex != -1)
            {
                Article article = handler.getArticle(listBoxArticles.SelectedIndex);
                handler.Remove(article);
                UpdateList();
            }
        }
        private void UpdateList()
        {
            listBoxArticles.Items.Clear();
            List<Article> list = handler.getArticles();
            for (int i = 0; i < list.Count; i++)
            {
                listBoxArticles.Items.Add(list[i].Title + " " + list[i].Author);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxArticles.SelectedIndex != -1)
            {
                Article article = handler.
                    getArticle(listBoxArticles.SelectedIndex);
                FormArticle formArticle = new FormArticle();
                formArticle.textBoxArticle.Text = article.Title;
                formArticle.richTextBox1.Text = article.Content;
                formArticle.textBoxAuthor.Text = article.Author;
                formArticle.textBoxTheme.Text = article.Theme;
                formArticle.numericUpDownAge.Value = article.Age;
                if (formArticle.ShowDialog() == DialogResult.OK)
                {
                    handler.getArticle(listBoxArticles.SelectedIndex).Age =
                        (int)formArticle.numericUpDownAge.Value;
                    handler.getArticle(listBoxArticles.SelectedIndex).Theme =
                        formArticle.textBoxTheme.Text;
                    handler.getArticle(listBoxArticles.SelectedIndex).Title =
                        formArticle.textBoxArticle.Text;
                    handler.getArticle(listBoxArticles.SelectedIndex).Content =
                        formArticle.richTextBox1.Text;
                    UpdateList();

                }
            }
        }

        private void listBoxArticles_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxArticles.SelectedIndex != -1)
            {
                Article article = handler.
                    getArticle(listBoxArticles.SelectedIndex);
                FormReadArticle formReadArticle = new FormReadArticle(article);
                formReadArticle.Show();
            }
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserAuthentification.ExitUesr();
            FormAutorization.instance!.Show();
            this.Close();

        }
    }
}
