using Org.BouncyCastle.Tls.Crypto;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text)
                    || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(titleTextBox.Text)
                    || string.IsNullOrEmpty(websiteTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields to add an account");
                }
                else
                {
                    AccountManager accountManager = new()
                    {
                        Title = titleTextBox.Text,
                        Website = websiteTextBox.Text,
                        Email = emailTextBox.Text,
                        Username = usernameTextBox.Text,
                        Password = passwordTextBox.Text
                    };

                    AccountManager.AddAccount(accountManager);
                    MessageBox.Show("Account added.");
                    DialogResult = DialogResult.OK;
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
