using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordManager_Desktop
{
    internal class LoginManager : IDataManager, IEmailManager
    {
        public int ID { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }

        // VerifyAccount() : Verifies user account credentials.
        // ResetPassword(): Resets user password.

        public static void CreateMasterAccount(LoginManager loginManager)
        {
            string query = "INSERT INTO MasterAccount (Username, Password, Email) VALUES (@Username, @Password, @Email)";

            IDataManager.ExecuteQuery(query, new
            {
                loginManager.Username,
                loginManager.Password,
                loginManager.Email
            });
        }

        public static void VerifyAccount(LoginManager loginManager)
        {
            string query = "SELECT * FROM MasterAccount WHERE Username = @Username AND Password = @Password";

            IDataManager.ExecuteQuery(query, new
            {
                loginManager.Username,
                loginManager.Password
            });
        }
    }
}
