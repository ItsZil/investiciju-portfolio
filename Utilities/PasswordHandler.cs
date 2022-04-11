using System;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNet.Identity;

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
    }
}
