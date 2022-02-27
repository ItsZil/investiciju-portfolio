using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace investiciju_portfolio.Utilities
{
    public class DatabaseConnection
    {
        private string connectionString = "server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio";
        MySqlConnection connection;

        /// <summary>
        /// Opens a connection to the database server.
        /// </summary>
        /// <returns>A boolean indicating if connected successfully.</returns>
        public bool OpenConnection()
        {
            if (connectionString.Length == 0)
                return false; // Maybe throw an exception

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection with database: " + ex.Message);
                return false;
            }
            return true;
        }

        /*
        public async void TestConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                using var command = new MySqlCommand(String.Format("SELECT first_name FROM users WHERE username={0}", "'testname'"), connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var value = reader.GetValue(0);
                    MessageBox.Show(value.ToString());
                }
            }
        }
        */
    }
}
