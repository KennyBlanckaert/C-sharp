using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace SchoolServiceLibrary.database
{
    public class DatabaseConfig
    {
        // Fields
        private static DatabaseConfig instance;
        private MySqlConnection connection;
        private string user;
        private string password;
        private string database;

        // Singleton
        private DatabaseConfig() { }

        // Get instance
        public static DatabaseConfig getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConfig();
            }

            return instance;
        }

        // Getters & Setters
        public string User
        {
            get { return this.user; }
            set { this.user = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Database
        {
            get { return this.database; }
            set { this.database = value; }
        }

        // Open Connect
        public bool Connect()
        {
            if (this.user != null && this.password != null && this.database != null)
            {
                string connectionString = string.Format("Server=localhost; database={0}; UID={1}; password={2}", this.database, this.user, this.password);
                connection = new MySqlConnection(connectionString);
                connection.Open();

                return (connection.State == ConnectionState.Open);
            }

            return false;
        }

        // Get MySQLConnection object
        public MySqlConnection MySQLConnection()
        {
            return this.connection;
        }

        // Close connection
        public void Close()
        {
            connection.Close();
        }

    }
}
