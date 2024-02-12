using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LifeGame
{
    class Database
    {
        private const string ConnectionString = "Server=localhost;Database=LifeGame;Uid=root;Pwd=root;";

        public MySqlConnection Connection { get; }

        public Database()
        {
            Connection = new MySqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                {
                    Connection.Open();
                    Console.WriteLine("Database connection opened.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening the database connection: {ex.Message}");
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                    Console.WriteLine("Database connection closed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing the database connection: {ex.Message}");
            }
        }

        public void CreateUser(string username, string password)
        {
            // Hash du mot de passe avant de l'enregistrer dans la base de données
            string hashedPassword = HashPassword(password);

            // Requête SQL pour insérer un nouvel utilisateur
            string query = "INSERT INTO User (Login, Password) VALUES (@Username, @PasswordHash)";

            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                OpenConnection();

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        private string HashPassword(string password)
        {
            // Utilisation de SHA256 pour le hachage du mot de passe
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir les octets hachés en une chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public bool ValidateUser(string username, string password)
        {
            // Requête SQL pour vérifier si l'utilisateur existe avec le login et le mot de passe fournis
            string query = "SELECT COUNT(*) FROM User WHERE Login = @Username AND Password = @PasswordHash";

            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                // Hash du mot de passe avant la comparaison
                string hashedPassword = HashPassword(password);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                OpenConnection();

                // Exécution de la requête SQL et récupération du nombre d'enregistrements correspondants
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                CloseConnection();

                // Si le nombre d'enregistrements correspondants est supérieur à 0, l'utilisateur est valide
                return count > 0;
            }
        }
    }
}
