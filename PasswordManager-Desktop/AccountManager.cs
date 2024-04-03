using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_Desktop
{
    internal class AccountManager : IDataManager
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Website { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        // AddAccount(): Adds a new account to the manager
        public static void AddAccount(AccountManager accountManager)
        {
            string query = "INSERT INTO Accounts (Title, Website, Username, Password) VALUES (@Title, @Website, @Username, @Password)";

            IDataManager.Save(query, new
            {
                accountManager.Title,
                accountManager.Website,
                accountManager.Username,
                accountManager.Password,
            });
        }

        //// DeleteAccount(): Deletes an existing account.
        //public static void DeleteAccount(AccountManager accountManager)
        //{
        //    string query = "DELETE FROM Accounts (Title, Website, Username, Password) VALUES (@Title, @Website, @Username, @Password)";

        //    IDataManager.Save(query, new
        //    {
        //        accountManager.Title,
        //        accountManager.Website,
        //        accountManager.Username,
        //        accountManager.Password,
        //    });
        //}

        //// UpdateAccount(): Updates account information.
        //public static void UpdateAccount(AccountManager accountManager)
        //{
        //    string query = "Update Accounts Set (Title, Website, Username, Password) VALUES (@Title, @Website, @Username, @Password)";

        //    IDataManager.Save(query, new
        //    {
        //        accountManager.Title,
        //        accountManager.Website,
        //        accountManager.Username,
        //        accountManager.Password,
        //    });
        //}

        //// FetchAccount(): Retrieves account details.
        //public static void FetchAccount(AccountManager accountManager)
        //{
        //    string query = "INSERT INTO Accounts (Title, Website, Username, Password) VALUES (@Title, @Website, @Username, @Password)";

        //    IDataManager.Fetch(query, new
        //    {
        //        accountManager.Title,
        //        accountManager.Website,
        //        accountManager.Username,
        //        accountManager.Password,
        //    });
        //}

    }
}
