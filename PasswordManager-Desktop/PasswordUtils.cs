using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_Desktop
{
    internal class PasswordUtils
    {

        private readonly string? FilePath = ConfigurationManager.AppSettings["BadPasswordList"];
        private HashSet<string>? BadPasswords;

        // GeneratePassword(): Generates a secure password.
        public static string GeneratePassword()
        {
            const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string Symbols = "!@#$%^&*";

            Random rand = new();
            int length = rand.Next(12, 17); // Random length between 12 and 16 characters

            StringBuilder str = new(length);

            for (int i = 0; i < length; i++)
            {
                bool addCharacter = rand.Next(2) == 0;

                if (addCharacter)
                    str.Append(Characters[rand.Next(Characters.Length)]);
                else
                    str.Append(Symbols[rand.Next(Symbols.Length)]);
            }

            return str.ToString();
        }

        // CheckPassword(): Evaluates the strength of a password based upon its length and quality.
        public void CheckPassword(string password)
        {
            if (IsTooShort(password))
            {
                MessageBox.Show($"The password {password} is too short. It is recommended to use a password that is at least 12 characters in length.");
            }
            else if (IsBadPassword(password))
            {
                MessageBox.Show($"The password {password} is too predictable. A more complex password is recommended.");
            }
            else if (IsTooShort(password) && IsBadPassword(password))
            {
                MessageBox.Show($"The password {password} is too short and predictable. A longer and more complex password is recommended.");
            }

            MessageBox.Show("This password follows best practices for security.");
        }

        // IsShort(): Detects whether a password is too short (i.e., less than 12 characters).
        private static bool IsTooShort(string password)
        {
            if (password.Length < 12)
            {
                return true;
            }

            return false;
        }

        // IsBadPassword(): Determines whether a password is commmon or weak by comparing it to those in BadPasswordList.txt.
        private bool IsBadPassword(string password)
        {
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException($"Bad password list file not found at: {FilePath}");
            }
            else
            {
                BadPasswords ??= new HashSet<string>(File.ReadAllLines(FilePath));
                return BadPasswords.Contains(password);
            }
        }
    }
}
