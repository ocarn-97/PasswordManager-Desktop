namespace PasswordManager_Desktop
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            try
            {
                bool isMasterAccount = LoginManager.IsMasterAccount();
                if (isMasterAccount)
                {
                    LoginForm login = new();
                    login.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields.");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
    }
}
