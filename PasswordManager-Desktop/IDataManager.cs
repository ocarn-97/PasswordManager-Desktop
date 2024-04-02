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

        // Insert() : Executes insert query
        public static void Insert(string query, object? parameters)
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

        // Select() : Executes select query.
        public static List<Dictionary<string, object>> Select(string query, object? parameters)
        {
            List<Dictionary<string, object>> results = [];
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
                using SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, object> row = [];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    results.Add(row);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQLite Error: " + ex.Message);
            }
            finally
            {
                CloseConnection(connection);
            }
            return results;
        }

        // Update() : Executes update query.
        public static void Update(string query, object? parameters)
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

        // Delete() : Executes delete query.
        public static void Delete(string query, object? parameters)
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
