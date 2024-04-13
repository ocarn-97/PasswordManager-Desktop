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
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(checkTextBox.Text))
                {
                    MessageBox.Show("Please enter a password to check.");
                }
                else
                {
                    PasswordUtils passwordUtils = new();
                    passwordUtils.CheckPassword(checkTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
