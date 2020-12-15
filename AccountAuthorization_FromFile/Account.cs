using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAuthorization_FromFile
{
    struct Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
