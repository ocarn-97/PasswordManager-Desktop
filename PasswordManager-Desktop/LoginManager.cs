namespace PasswordManager_Desktop
{
    internal class LoginManager : IDataManager
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        // CreateMasterAccount(): Creates master account by inserting a record into the MasterAccount table.
        public static void CreateMasterAccount(LoginManager loginManager)
        {
            string query = "INSERT INTO MasterAccount (Username, Password) VALUES (@Username, @Password)";

            IDataManager.Save(query, new
            {
                loginManager.Username,
                loginManager.Password
            });
        }

        // VerifyCredentials(): Checks whether the inputted credentials correspond to those of the master account in the MasterAccount table.
        public static bool VerifyCredentials(LoginManager loginManager)
        {
            string query = "SELECT * FROM MasterAccount WHERE Username = @Username";
            List<Dictionary<string, object>> results = IDataManager.Fetch(query, new { loginManager.Username });

            if (results.Count > 0)
            {
                Dictionary<string, object> firstRow = results[0];
                object storedPassword = firstRow["Password"];

                if (storedPassword != null && storedPassword.ToString() == loginManager.Password)
                {
                    return true;
                }
            }

            return false;
        }

        // IsMasterAccount(): Checks whether a master account exists in the MasterAccount table.
        public static bool IsMasterAccount()
        {
            string query = "SELECT * FROM MasterAccount";

            List<Dictionary<string, object>> results = IDataManager.Fetch(query, null);

            if (results.Count > 0)
            {
                Dictionary<string, object> firstRow = results[0];
                object storedPassword = firstRow["Username"];

                if (storedPassword != null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
