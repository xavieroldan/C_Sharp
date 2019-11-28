using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppAspNetTest.Models
{
    public class LoginModel
    {
        public string name { get; set; }
        public string password { get; set; }
        public int errorLoginCount { get; set; }           
        public bool isLogged { get; set; }
        public bool isLocked { get; set; }
    }
}
