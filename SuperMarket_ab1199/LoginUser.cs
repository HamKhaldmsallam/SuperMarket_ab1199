using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_ab1199
{
    class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoginUser(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
