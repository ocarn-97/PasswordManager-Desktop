using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_Desktop
{
    internal class DatabaseUtils
    {
        private const string connectionString = @"Data Source=..\..\Files\PasswordManager-Desktop.db;Version=3;"; 

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new(connectionString);
            return connection;
        }


    }
}
