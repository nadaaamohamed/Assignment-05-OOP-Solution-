using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP.Question_02
{
    internal interface IAuthenticationService
    {
        public bool Authenticate(string username, string password);
        public bool AuthorizeUser(string username , string Role);

    }
}
