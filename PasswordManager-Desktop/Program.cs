using System.Configuration;

namespace PasswordManager_Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                bool isMasterAccount = LoginManager.IsMasterAccount();
                if (isMasterAccount)
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new LoginForm());
                }
                else
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new RegistrationForm());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}