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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox)!.Text.Length < 6)
            {
                labelWarning.Text = "Длина праоля должна быть не меньше 6 символов";
                return;
            }
            labelWarning.Text = "";
        }
    }
}
