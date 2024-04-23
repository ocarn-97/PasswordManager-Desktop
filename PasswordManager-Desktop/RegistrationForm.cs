namespace PasswordManager_Desktop
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields.");
                }
                else
                {
                    LoginManager newMasterAccount = new()
                    {
                        Username = usernameTextBox.Text,
                        Password = passwordTextBox.Text
                    };

                    LoginManager.CreateMasterAccount(newMasterAccount);
                    AccountForm accountForm = new();
                    accountForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
