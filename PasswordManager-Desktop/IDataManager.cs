using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_Desktop
{
    internal interface IDataManager
    {

        private const string ConnectionString = "Data Source=PasswordManager-Desktop.db;Version=3;";

        // GetConnection(): Establishes a connection to the database.
        private static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new(ConnectionString);
            return connection;
        }

        //CloseConnection(): Closes the database connection.
        private static void CloseConnection(SQLiteConnection connection)
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // ExecuteQuery() : Executes SQL queries.
        public static void ExecuteQuery(string query, object? parameters)
        {
            using SQLiteConnection connection = GetConnection();
            using SQLiteCommand command = new(query, connection);
            try
            {
                connection.Open();
                if (parameters != null)
                {
                    foreach (var prop in parameters.GetType().GetProperties())
                    {
                        command.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(parameters, null));
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQLite Error: " + ex.Message);
            }
            finally
            {
                CloseConnection(connection);
            }
        }
    }
}
