using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppAspNetTest.Models
{
    public class LoginModel
    {
        private string _user;
        private string _password;

        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
