using System;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace _4everGreen04.utilities
{
    public class connexion
    {
        // database connection
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return new MySqlConnection(connectionString);
        }

        //  open a database connection
        public static void OpenConnection(MySqlConnection connection)
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //  close a database connection
        public static void CloseConnection(MySqlConnection connection)
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //  execute SQL query
        public static void ExecuteQuery(string query)
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }


    }
}
