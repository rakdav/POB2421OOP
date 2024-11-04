namespace Lesson17
{
    public partial class FormAutorization : Form
    {
        private UserAuthentification userAurization;
        public static FormAutorization? instance;
        public FormAutorization()
        {
            InitializeComponent();
            instance = this;
            userAurization = new UserAuthentification();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (userAurization.Users != null)
            {
                foreach (User s in userAurization.Users!)
                {
                    source.Add(s.Username!);
                }
                textBoxLogin.AutoCompleteCustomSource = source;
                textBoxLogin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxLogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(userAurization.AuthentificationUser(textBoxLogin.Text,textBoxPassword.Text))
            {
                FormAtricles formAtricles = new FormAtricles();
                formAtricles.Show();
                this.Hide();
            }
        }
    }
}
