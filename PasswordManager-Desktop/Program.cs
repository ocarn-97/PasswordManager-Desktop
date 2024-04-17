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
            ApplicationConfiguration.Initialize();

            try
            {
                bool isMasterAccount = LoginManager.IsMasterAccount();
                if (isMasterAccount)
                {
                    Application.Run(new LoginForm());
                }
                else
                {
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