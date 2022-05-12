using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;
using MySqlConnector;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// A struct containing a password's hash and the salt necessary to decrypt it.
    /// </summary>
    public struct Password
    {
        public Password(string hash)
        {
            Hash = hash;
        }

        public string Hash { get; set; }

    }

    /// <summary>
    /// Static class containing methods to assist in hashing and unhashing passwords.
    /// </summary>
    static internal class PasswordHandler
    {

        /// <summary>
        /// Checks if a password meets the requirement of containing 1 number and 1 capital letter.
        /// </summary>
        /// <param name="password">The password string to check.</param>
        /// <returns>true if meets requirements, false otherwise.</returns>
        public static bool PasswordMeetsRequirements(string password)
        {
            return password.Length >= 8 &&
                password.Any(c => char.IsDigit(c)) &&
                password.Any(c => char.IsUpper(c)) &&
                password.Any(c => char.IsLower(c));
        }

        /// <summary>
        /// Hashes a password string using the PBKDF2 algorithm.
        /// </summary>
        /// <param name="password">Plain text password string.</param>
        /// <returns>A string of the hashed password.</returns>
        public static Password CreateHash(string password)
        {

            var passwordHasher = new PasswordHasher();
            var hash = passwordHasher.HashPassword(password);

            return new Password(hash);
        }

        /// <summary>
        /// Verifies if the password hash is correct.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">User password hash</param>
        /// <param name="setSettings">Whether to set local user settings</param>
        /// <returns>True if password is correct, false otherwise.</returns>
        public static bool VerifyPassword(string username, string password, bool setSettings = false)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            con = new MySqlConnection("server=localhost;user=investiciju_portfolio;password=ipprojektas#;database=investiciju_portfolio");
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM `users` where username='" + username + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                var passwordHasher = new PasswordHasher();
                var isVerified = passwordHasher.VerifyHashedPassword(dr["password"].ToString(), password) != PasswordVerificationResult.Failed;
                if (isVerified)
                {
                    if (setSettings)
                    {
                        // Set settings before logging in.
                        SettingsHandler.SetSettings(dr["username"].ToString(), dr["first_name"].ToString(), dr["surname"].ToString(), (int)dr["id"]);
                    }
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            else
            {
                con.Close();
                return false;
            }
        }

        /// <summary>
        /// Changes the currently logged in user's password.
        /// </summary>
        /// <param name="newPassword">The new password to set</param>
        /// <returns>True if successful, false otherwise.</returns>
        public static bool ChangePassword(string newPassword)
        {
            int userId = Properties.Settings.Default.id;
            if (userId < 1)
                return false;

            try
            {
                Password userPassword = CreateHash(newPassword);
                DatabaseConnection dbConnection = new DatabaseConnection();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE users SET password=@password WHERE id=@id"));
                command.Parameters.AddWithValue("@password", userPassword.Hash);
                command.Parameters.AddWithValue("@id", userId);
                dbConnection.ExecuteCommand(command);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
