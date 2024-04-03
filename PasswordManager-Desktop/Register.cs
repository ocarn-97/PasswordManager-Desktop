namespace PasswordManager_Desktop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void RegisterAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            else
            {
                LoginManager newMasterAccount = new()
                {
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    Email = emailTextBox.Text
                };

                LoginManager.CreateMasterAccount(newMasterAccount);
            }
        }
    }
}
