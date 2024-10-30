using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson17
{
    public partial class FormRegistration : Form
    {
        private UserRegistration userRegistration;
        public FormRegistration()
        {
            InitializeComponent();
            userRegistration=new UserRegistration();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox)!.Text.Length < 6)
            {
                labelWarning.Text = "Длина праоля должна быть не меньше 6 символов";
                return;
            }
            labelWarning.Text = "";
        }

        private void textBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox)!.Text;
            if (text != textBoxPassword.Text)
            {
                labelPasswordWarning.Text = "Пароли должны совпадать";
                return;
            }
            labelPasswordWarning.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string? pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (!Regex.IsMatch((sender as TextBox)!.Text, pattern,
                RegexOptions.IgnoreCase))
            {
                labelEmailWarning.Text = "Не соотвует email";
                return;
            }
            labelEmailWarning.Text = "";
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if(userRegistration.ExistUser(textBoxPassword.Text))
            {
                MessageBox.Show("Пользователь с таким логином существует!");
                return;
            }
            int id = userRegistration.getUsers().Count + 1;
            User user = new User();
            user.Id=id;
            user.Username=textBoxLogin.Text;
            user.FirstName = textBoxFirstName.Text;
            user.SecondName = textBoxLastName.Text;
            user.Email = textBoxEmail.Text;
            user.Password = textBoxPassword.Text;
            user.RegistrationDate=DateTime.Now;
            user.BirthDate = dateTimePickerBirth.Value;
            userRegistration.RegisterUser(user);
            userRegistration.SerializeUsersToJson(userRegistration.getUsers(),
                "users.json");
            this.Close();
        }

    }
}
