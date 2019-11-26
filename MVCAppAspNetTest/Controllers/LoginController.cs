using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAppAspNetTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCAppAspNetTest.Controllers
{   
    public class LoginController : Controller
    {
          public string Test()
        {
            return "Connection OK";
        }

        [HttpPost]
        public string VerifyLogin()
        {
            LoginModel user = new LoginModel();
            user.name = HttpContext.Request.Form["name"];
            user.password = HttpContext.Request.Form["pass"];

            if (user.name == "root" && user.password == "toor")
            {
                return "Logged";
            }
            else
            {
                return "No Logged";
            }
        }
    }
}
