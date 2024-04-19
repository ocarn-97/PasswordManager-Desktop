namespace PasswordManager_Desktop
{
    public partial class LoginForm : Form
    {

        private int loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }
                else
                {
                    if (loginAttempts < 3)
                    {
                        LoginManager credentials = new()
                        {
                            Username = usernameTextBox.Text,
                            Password = passwordTextBox.Text,
                        };

                        bool isValidCredentials = LoginManager.VerifyCredentials(credentials);

                        if (isValidCredentials)
                        {
                            MessageBox.Show("Login successful");
                            AccountForm accountForm = new();
                            accountForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and password combination. Please try again.");
                            loginAttempts++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have exceeded the maximum number of login attempts. The application will now close. Goodbye!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
