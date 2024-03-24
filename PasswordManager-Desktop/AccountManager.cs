﻿using System;
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

        public List<Account> accounts = [];

        // AddAccount(): Adds a new account to the manager
        // DeleteAccount(): Deletes an existing account.
        // UpdateAccount(): Updates account information.
        // FetchAccount(): Retrieves account details.

        //public void InsertData(Account account)
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "INSERT INTO Accounts (Username, Password) VALUES (@Username, @Password)";
        //        using (SQLiteCommand command = new SQLiteCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Username", account.Username);
        //            command.Parameters.AddWithValue("@Password", account.Password);
        //            command.ExecuteNonQuery();
        //        }
        //    }
    }
}
