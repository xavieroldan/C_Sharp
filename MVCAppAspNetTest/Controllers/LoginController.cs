using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAppAspNetTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCAppAspNetTest.Controllers
{
    public class Login : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        //GET: / Test
        public string Test()
        {
            return "Connection OK";
        }

        [HttpPost]
        public string LoginUser(LoginModel user)
        {
            if(user.User=="root" && user.Password=="toor")
            {
                return "Logged";
            }
            else
            {
                return "NO logged";
            }
        }
    }
}
