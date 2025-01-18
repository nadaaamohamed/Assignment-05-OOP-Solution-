using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP.Question_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            return (username == "admin" && password == "123N");  
      
        }

        public bool AuthorizeUser(string username, string Role)
        {
            return (username == "admin" && Role == "Admin");
        }
    }
}
