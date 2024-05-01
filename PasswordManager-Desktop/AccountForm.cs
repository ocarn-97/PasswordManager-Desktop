namespace PasswordManager_Desktop
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void PopulateListView()
        {
            try
            {
                listView.Items.Clear();
                List<Dictionary<string, object>> items = AccountManager.FetchAccounts() ?? [];

                if (items.Count > 0)
                {
                    foreach (Dictionary<string, object> item in items)
                    {
                        item.TryGetValue("ID", out object? id);
                        item.TryGetValue("Title", out object? title);
                        item.TryGetValue("Website", out object? website);
                        item.TryGetValue("Email", out object? email);
                        item.TryGetValue("Username", out object? username);
                        item.TryGetValue("Password", out object? password);

                        ListViewItem listViewItem = new(new string[]
                        {
                            id?.ToString() ?? "",
                            title?.ToString() ?? "",
                            website?.ToString() ?? "",
                            email?.ToString() ?? "",
                            username?.ToString() ?? "",
                            password?.ToString() ?? ""
                        });

                        listView.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                using AddForm addForm = new();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    PopulateListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem selectedItem in listView.SelectedItems)
                    {
                        int id = int.Parse(selectedItem.SubItems[0].Text);
                        listView.Items.Remove(selectedItem);
                        AccountManager.DeleteAccount(id);
                        MessageBox.Show($"Account with ID {id} has been deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                string generatedPassword = PasswordUtils.GeneratePassword();
                MessageBox.Show(generatedPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForm checkForm = new();
                checkForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count > 0)
                {
                    UpdateForm updateForm = new(int.Parse(listView.SelectedItems[0].SubItems[0].Text));
                    updateForm.PopulateUpdateForm(listView.SelectedItems[0]);

                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        PopulateListView();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
