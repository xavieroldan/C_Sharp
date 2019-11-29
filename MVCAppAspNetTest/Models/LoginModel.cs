using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppAspNetTest.Models
{
    public class LoginModel
    {
        public int userid { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int errorLogin { get; set; }  
        public bool isLocked { get; set; }
    }
}
