namespace PasswordManager_Desktop
{
    internal class LoginManager : IDataManager, IEmailManager
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }


        // ResetPassword(): Resets user password.

        // CreateMasterAccount() : Creates master account by inserting record into MasterAccount table.
        public static void CreateMasterAccount(LoginManager loginManager)
        {
            string query = "INSERT INTO MasterAccount (Username, Password, Email) VALUES (@Username, @Password, @Email)";

            IDataManager.Save(query, new
            {
                loginManager.Username,
                loginManager.Password,
                loginManager.Email
            });

        }

        // IsMasterAccount() : Checks whether a master account exists by querying the MasterAccount table.
        public static bool IsMasterAccount(LoginManager loginManager)
        {
            string query = "SELECT * FROM MasterAccount WHERE Username = @Username AND Password = @Password";

            List<Dictionary<string, object>> results =
            IDataManager.Fetch(query, new
            {
                loginManager.Username,
                loginManager.Password
            });
            if (results.Count > 0 || results != null) {return true;}
            else { return false; }
        }
    }
}
