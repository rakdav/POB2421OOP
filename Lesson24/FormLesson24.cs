using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson24
{
    public partial class FormLesson24 : Form
    {
        private List<User> users = new List<User>();
        public FormLesson24()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser(textBoxFirstName.Text,textBoxLastName.Text,
                int.Parse(textBoxAge.Text));
            UpdateList();
            textBoxAge.Text=textBoxFirstName.Text=textBoxLastName.Text="";
        }
        private void AddUser(string name,string lastName,int age)
        {
            users.Add(new User(name, lastName, age));
        }
        private void UpdateList()
        {
            dataGridViewUser.Rows.Clear();
            foreach (User user in users)
            {
                dataGridViewUser.Rows.Add(user.Name,user.SurName,user.Age);
            }
        }
    }
}
