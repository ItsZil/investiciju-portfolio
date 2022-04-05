using System;
using System.Linq;
using System.Security.Cryptography;

namespace investiciju_portfolio.Utilities
{
    /// <summary>
    /// A struct containing a password's hash and the salt necessary to decrypt it.
    /// </summary>
    public struct Password
    {
        public Password(string hash, string salt)
        {
            Hash = hash;
            Salt = salt;
        }

        public string Hash { get; set; }
        public string Salt { get; set; }
    }

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
        public static Password CreateHash(string password)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

            // Generate unique random salt
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);

            // Generate password hash
            Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(password, salt, ITERATIONS);
            string hashedPassword = Convert.ToBase64String(hash.GetBytes(HASH_SIZE));

            return new Password(hashedPassword, Convert.ToBase64String(salt));
        }
    }
}
