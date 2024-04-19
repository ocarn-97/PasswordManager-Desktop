namespace PasswordManager_Desktop
{
    internal class AccountManager : IDataManager
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        // AccountManager(): Automatically assigns a GUID upon account creation. 
        public AccountManager()
        {
            ID = Guid.NewGuid().GetHashCode();
        }

        // AddAccount(): Adds a new account to the Accounts table.
        public static void AddAccount(AccountManager accountManager)
        {
            string query = "INSERT INTO Accounts (Title, Website, Email, Username, Password) VALUES (@Title, @Website, @Email, @Username, @Password)";

            IDataManager.Save(query, new
            {
                accountManager.Title,
                accountManager.Website,
                accountManager.Email,
                accountManager.Username,
                accountManager.Password,
            });
        }

        // DeleteAccount(): Deletes an existing account from the Accounts table.
        public static void DeleteAccount(int ID)
        {
            string query = "DELETE FROM Accounts WHERE ID = @ID";

            IDataManager.Save(query, new {ID});
        }

        // UpdateAccount(): Updates an account in the Accounts table.
        public static void UpdateAccount(AccountManager accountManager)
        {
            string query = "UPDATE Accounts SET Title = @Title, Website = @Website, Email = @Email, Username = @Username, Password = @Password WHERE ID = @ID";

            IDataManager.Save(query, new
            {
                accountManager.ID,
                accountManager.Title,
                accountManager.Website,
                accountManager.Email,
                accountManager.Username,
                accountManager.Password,
            });
        }

        // FetchAccount(): Fetches accounts from the Accounts table.
        public static List<Dictionary<string, object>> FetchAccounts()
        {
            string query = "SELECT * FROM Accounts";

            List<Dictionary<string, object>> results = IDataManager.Fetch(query, null);
            return results;
        }
    }
}
