using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager_Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            int loginAttempts = 0;

            try
            {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }
                else
                {
                    loginAttempts++;

                    if (loginAttempts > 3)
                    {
                        MessageBox.Show("You have exceeded the maximum number of login attempts. Please reopen the application and try again.");
                        return;
                    }

                    LoginManager credentials = new()
                    {
                        Username = usernameTextBox.Text,
                        Password = passwordTextBox.Text,
                    };

                    bool isValidCredentials = LoginManager.VerifyCredentials(credentials);
                    if (isValidCredentials)
                    {
                        AccountForm accountForm = new();
                        accountForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and password combination. Please try again.");
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
