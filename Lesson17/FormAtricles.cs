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

        public FormAtricles()
        {
            InitializeComponent();
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

            }
        }
    }
}
