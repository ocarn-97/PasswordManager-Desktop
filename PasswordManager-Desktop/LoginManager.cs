using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordManager_Desktop
{
    internal class LoginManager : IDataManager, IEmailManager
    {
        public int ID { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }

        // VerifyAccount() : Verifies user account credentials.
        // ResetPassword(): Resets user password.


    }
}
