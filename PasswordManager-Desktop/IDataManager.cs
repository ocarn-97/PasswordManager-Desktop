﻿using System.Configuration;
using System.Data.SQLite;

namespace PasswordManager_Desktop
{
    internal interface IDataManager
    {
        // GetConnection(): Establishes a connection to the database.
        public static SQLiteConnection GetConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SQLiteConnection connection = new(ConnectionString);
            return connection;
        }

        //CloseConnection(): Closes the database connection as a redundancy.
        public static void CloseConnection(SQLiteConnection connection)
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // Save(): Executes create, update, and delete queries.
        public static void Save(string query, object? parameters)
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

        // Fetch(): Executes select queries.
        public static List<Dictionary<string, object>> Fetch(string query, object? parameters)
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
                    Dictionary<string, object> row = new Dictionary<string, object>();
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
    }
}
