using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_Desktop
{
    internal class DataManager
    {

        private const string connectionString = "Data Source=PasswordManager-Desktop.db;Version=3;";

        // GetConnection(): Establishes a connection to the database.
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new(connectionString);
            return connection;
        }

        //CloseConnection(): Closes the database connection.
        public static void CloseConnection(SQLiteConnection connection)
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // ExecuteQuery() : Executes SQL queries.
        public static void ExecuteQuery(string query)
        {
            using SQLiteConnection connection = GetConnection();
            using SQLiteCommand command = new(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQLite Error executing query: " + ex.Message);
            }
            finally
            {
                CloseConnection(connection);
            }
        }
    }
}
