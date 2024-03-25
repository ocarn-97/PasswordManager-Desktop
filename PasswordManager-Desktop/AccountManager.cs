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
        internal class Account
        {
            public int ID { get; set; }
            public string? Title { get; set; }
            public string? Website { get; set; }
            public string? Username { get; set; }
            public string? Password { get; set; }
        }

        // AddAccount(): Adds a new account to the manager
        // DeleteAccount(): Deletes an existing account.
        // UpdateAccount(): Updates account information.
        // FetchAccount(): Retrieves account details.

    }
}
