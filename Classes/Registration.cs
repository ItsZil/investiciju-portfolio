using System;
using MySqlConnector;
using investiciju_portfolio.Utilities;

namespace investiciju_portfolio.Classes
{
    /// <summary>
    /// Class to handle registration of new users.
    /// </summary>
    internal static class Registration
    {
        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="name">First name</param>
        /// <param name="surname">Surname</param>
        /// <param name="password">Plain text password</param>
        /// <returns></returns>
        public static bool RegisterUser(string username, string name, string surname, string password)
        {
            try
            {
                Password userPassword = PasswordHandler.CreateHash(password);
                DatabaseConnection dbConnection = new DatabaseConnection();

                MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO users (username, password, salt, first_name, last_name) VALUES (@username, @password, @salt, @first_name, @surname)"));
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", userPassword.Hash);
                command.Parameters.AddWithValue("@salt", userPassword.Salt);
                command.Parameters.AddWithValue("@first_name", name);
                command.Parameters.AddWithValue("@surname", surname);

                dbConnection.ExecuteCommand(command);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
