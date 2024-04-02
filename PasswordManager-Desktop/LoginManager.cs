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

        // ResetPassword(): Resets user password.

        // CreateMasterAccount() : Creates master account by inserting into MasterAccount table.
        public static void CreateMasterAccount(LoginManager loginManager)
        {
            string query = "INSERT INTO MasterAccount (Username, Password, Email) VALUES (@Username, @Password, @Email)";

            IDataManager.Insert(query, new
            {
                loginManager.Username,
                loginManager.Password,
                loginManager.Email
            });
        }

        // CheckExistenceOfAccount() : Checks whether a master account exists by querying the MasterAccount table.
        public static bool CheckExistenceOfAccount(LoginManager loginManager)
        {
            string query = "SELECT * FROM MasterAccount WHERE Username = @Username AND Password = @Password";

            List<Dictionary<string, object>> results = IDataManager
            .Select(query, new
            {
                loginManager.Username,
                loginManager.Password
            });
            if (results.Count > 0 || results != null) {return true;}
            else { return false; }
        }
    }
}
