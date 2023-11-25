using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Lab3
{
    public class DatabaseHandler
    {
        private readonly string connectionString;

        public DatabaseHandler(string server, string database)
        {
            connectionString = $"Data Source={server}; Initial Catalog={database}; Integrated Security=true; TrustServerCertificate=True";
        }

        public void AddData(string login, string password, string repeatPassword, string authResult, string errorMessage)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (login, password, repeat_password, result,  message_error) VALUES (@login, @password, @repeatPassword, @authResult, @errorMessage)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@repeatPassword", repeatPassword);
                    cmd.Parameters.AddWithValue("@authResult", authResult);
                    cmd.Parameters.AddWithValue("@errorMessage", errorMessage);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string GetData(string login, string password, string repeatPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT result FROM Users WHERE login = @login AND password = @password AND repeat_password = @repeatPassword";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@repeatPassword", repeatPassword);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public void DeleteData(string login, string password, string repeatPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Users WHERE login = @login AND password = @password AND repeat_password = @repeatPassword";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@repeatPassword", repeatPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
