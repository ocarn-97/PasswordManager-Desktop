using System.Configuration;
using System.Text;

namespace PasswordManager_Desktop
{
    internal class PasswordUtils
    {

        private readonly string? FilePath = ConfigurationManager.AppSettings["BadPasswordList"];

        // GeneratePassword(): Generates a secure password.
        public static string GeneratePassword()
        {
            const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string Symbols = "!@#$%^&*";

            Random rand = new();
            int length = rand.Next(12, 17);

            StringBuilder str = new(length);

            for (int i = 0; i < length; i++)
            {
                bool addCharacter = rand.Next(2) == 0;

                if (addCharacter)
                { str.Append(Characters[rand.Next(Characters.Length)]); }
                else
                { str.Append(Symbols[rand.Next(Symbols.Length)]); }
            }

            return str.ToString();
        }

        // CheckPassword(): Evaluates the strength of a password based upon its length and quality.
        public void CheckPassword(string password)
        {
            if (IsTooShort(password) && IsBadPassword(password))
            {
                MessageBox.Show($"The password {password} is too short and predictable. A longer and more complex password is recommended.");
            }
            else if (IsTooShort(password))
            {
                MessageBox.Show($"The password {password} is too short. It is recommended to use a password that is at least 12 characters in length.");
            }
            else if (IsBadPassword(password))
            {
                MessageBox.Show($"The password {password} is too predictable. A more complex password is recommended.");
            }
            else
            {
                MessageBox.Show("This password follows best practices for security.");
            }
        }

        // IsShort(): Detects whether a password is too short (i.e., less than 12 characters).
        private static bool IsTooShort(string password)
        {
            if (password.Length < 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // IsBadPassword(): Determines whether a password is common or weak by comparing it to those in BadPasswordList.txt.
        private bool IsBadPassword(string password)
        {
            if (FilePath == null)
            {
                throw new InvalidOperationException("FilePath is null.");
            }

            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException($"File not found at: {FilePath}");
            }

            HashSet<string> badPasswords = new();
            using (StreamReader reader = new(FilePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    badPasswords.Add(line.Trim());
                }
            }

            return badPasswords.Contains(password.Trim());
        }
    }
}
