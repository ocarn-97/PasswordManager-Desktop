namespace PasswordManager_Desktop
{
    public partial class UpdateForm : Form
    {
        private readonly int ID;

        public UpdateForm(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text)
                    || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(titleTextBox.Text)
                    || string.IsNullOrEmpty(websiteTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields to update an account");
                }
                else
                {
                    AccountManager accountManager = new()
                    {
                        ID = ID,
                        Title = titleTextBox.Text,
                        Website = websiteTextBox.Text,
                        Email = emailTextBox.Text,
                        Username = usernameTextBox.Text,
                        Password = passwordTextBox.Text
                    };

                    AccountManager.UpdateAccount(accountManager);
                    MessageBox.Show("Account updated.");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PopulateUpdateForm(ListViewItem item)
        {
            if (item != null && item.SubItems.Count >= 6)
            {
                titleTextBox.Text = item.SubItems[1].Text;
                websiteTextBox.Text = item.SubItems[2].Text;
                emailTextBox.Text = item.SubItems[3].Text;
                usernameTextBox.Text = item.SubItems[4].Text;
                passwordTextBox.Text = item.SubItems[5].Text;
            }
        }
    }
}
