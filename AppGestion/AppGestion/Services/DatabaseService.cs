using MySql.Data.MySqlClient;
using System;

namespace AppGestion.Services
{
    public class DatabaseService
    {
        private string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void TestConnection()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connexion à la base réussie !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion : " + ex.Message);
                }
            }
        }
    }
}
