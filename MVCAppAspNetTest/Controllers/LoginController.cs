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
        public IActionResult VerifyLogin()
        {
            LoginModel user = new LoginModel();
            user.name = HttpContext.Request.Form["name"];
            user.password = HttpContext.Request.Form["pass"];
            int logTryes = user.errorLoginCount;

            if (user.name == "root" && user.password == "toor")
            {
                user.isLogged = true;
                //save user to db
                return View("FirstScreen");
            }
            else
            {
                user.isLogged = false;
                if(logTryes==0|| logTryes==null)
                {
                    user.errorLoginCount = 1;
                }               
                else
                {
                    int count = user.errorLoginCount;
                    user.errorLoginCount += count;
                    if (logTryes >= Tools.Constants.LogTryes)
                        {
                            user.isLocked = true;
                            //save user to db
                            return View("LockedUser");
                        }
                }
                //save user to db
                return View("ErrorLogin");
            }
        }

        [HttpPost]
        [HttpGet]
        public IActionResult LogScreen()
        {
            return View("Index");
        }

        [HttpPost]
        [HttpGet]
        public IActionResult FirstScreen()
        {
            return View("FirstScreen");
        }

        [HttpPost]
        [HttpGet]
        public IActionResult LockedUser()
        {
            return View("LockedUser");
        }

    }
}
