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
            AddUser(textBoxFirstName.Text, textBoxLastName.Text,
                int.Parse(textBoxAge.Text));
            UpdateList();
        }
        private void AddUser(string name, string lastName, int age)
        {
            users.Add(new User(name, lastName, age));
        }
        private void UpdateList()
        {
            dataGridViewUser.Rows.Clear();
            foreach (User user in users)
            {
                dataGridViewUser.Rows.Add(user.Name, user.SurName, user.Age);
            }
            textBoxAge.Text = textBoxFirstName.Text = textBoxLastName.Text = "";
            buttonEdit.Enabled = false;
        }


        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                buttonEdit.Enabled = true;
                int index = dataGridViewUser.SelectedRows[0].Index;
                textBoxFirstName.Text = users[index].Name;
                textBoxLastName.Text = users[index].SurName;
                textBoxAge.Text = users[index].Age.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                int index = dataGridViewUser.SelectedRows[0].Index;
                users[index].Name = textBoxFirstName.Text;
                users[index].SurName = textBoxLastName.Text;
                users[index].Age = int.Parse(textBoxAge.Text);
                UpdateList();
                
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                int index = dataGridViewUser.SelectedRows[0].Index;
                DeleteItem(index);
                UpdateList();
            }
        }

        private void DeleteItem(int index)
        {
            users.RemoveAt(index);
        }

        private void dataGridViewUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewUser.SelectedRows.Count > 0)
                {
                    int index = dataGridViewUser.SelectedRows[0].Index;
                    DeleteItem(index);
                    UpdateList();
                }
            }
        }
    }
}
