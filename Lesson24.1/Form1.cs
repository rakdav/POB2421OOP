using System;

namespace Lesson24._1
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            users.Add(new User(textBoxFirstName.Text,
                textBoxLastName.Text, int.Parse(textBoxAge.Text)));
            UpdateForm();
        }
        private void UpdateForm()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = users;
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
            {
                dataGridViewUsers.Columns[i].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
            textBoxAge.Text = textBoxFirstName.Text =
                textBoxLastName.Text = String.Empty;
            buttonEdit.Visible = false;
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int index = dataGridViewUsers.SelectedRows[0].Index;
                textBoxFirstName.Text = users[index].Name;
                textBoxLastName.Text = users[index].SurName;
                textBoxAge.Text = users[index].Age.ToString();
                buttonEdit.Visible = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int index = dataGridViewUsers.SelectedRows[0].Index;
                users[index].Name =textBoxFirstName.Text;
                users[index].SurName = textBoxLastName.Text;
                users[index].Age =int.Parse(textBoxAge.Text);
                UpdateForm();
            }
        }
    }
}
