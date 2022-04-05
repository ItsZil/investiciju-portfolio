using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// Static class containing methods to assist in hashing and unhashing passwords.
    /// </summary>
    static internal class PasswordHandler
    {
        public const int SALT_SIZE = 24; // Size in bytes
        public const int HASH_SIZE = 24; // Size in bytes
        public const int ITERATIONS = 100000; // Number of PBKDF2 iterations

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
        public static string CreateHash(string password)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

            // Generate unique random salt
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);

            // Generate password hash
            Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(password, salt, ITERATIONS);
            string hashedPassword = hash.GetBytes(HASH_SIZE).ToString();

            return hashedPassword;
        }
    }
}
