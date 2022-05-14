using System;
using MySqlConnector;
using investiciju_portfolio.Utilities;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;

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
                MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO users (username, password, first_name, surname) VALUES (@username, @password, @first_name, @surname)"));
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", userPassword.Hash);
                command.Parameters.AddWithValue("@first_name", name);
                command.Parameters.AddWithValue("@surname", surname);
                dbConnection.ExecuteCommand(command);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a user exists with the provided username.
        /// </summary>
        /// <param name="username">The username to search for.</param>
        /// <returns>true if username unique, false if exists.</returns>
        public static bool IsUsernameUnique(string username)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                
                using (dbConnection.connection)
                {
                    using (var command = new MySqlCommand(String.Format("SELECT 1 FROM users WHERE username='{0}'", username), dbConnection.connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(0) != null)
                                    return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
