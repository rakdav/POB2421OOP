namespace Lesson17
{
    public partial class FormAutorization : Form
    {
        private UserRegistration userRegistration;
        public FormAutorization()
        {
            InitializeComponent();
            userRegistration = new UserRegistration();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (userRegistration.Users != null)
            {
                foreach (User s in userRegistration.Users!)
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
    }
}
