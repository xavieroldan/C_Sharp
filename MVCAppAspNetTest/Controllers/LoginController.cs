using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAppAspNetTest.Clases;
using MVCAppAspNetTest.Models;
using MySql.Data.MySqlClient;

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
        public async Task<IActionResult> VerifyLogin()
        {
            LoginModel user = new LoginModel();
            LoginModel logedUser = new LoginModel();
            List<LoginModel> listUsers = new List<LoginModel>();
            int logTryes = 0;
            bool isPresentUser = false;

            user.name = HttpContext.Request.Form["name"];
            user.password = HttpContext.Request.Form["pass"];

            try
            {
                UserContext context = HttpContext.RequestServices.GetService(typeof(UserContext)) as UserContext;
                listUsers = await context.GetAllUsersAsync();
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            
            //Validate user
            foreach (var item in listUsers)
            {
                if(item.name == user.name)
                {
                    isPresentUser = true;
                    logedUser = item;
                }
            }

            if (isPresentUser && user.name == logedUser.name && user.password == logedUser.password)
            {                
                //Is logged correctly
                if(logedUser.isLocked)
                {
                    //Locked
                    return View("LockedUser");
                }
                else
                {
                    //Logged correctly
                    //update db : reset loged tryes
                    logedUser.errorLogin = 0;
                    UserContext context = HttpContext.RequestServices.GetService(typeof(UserContext)) as UserContext;
                    context.UpdateAsync(logedUser);
                    return View("FirstScreen");
                }                
            }
            else
            {
                //increasing one the login error tryes
                logedUser.errorLogin++;
                //Is locked now? =>Update user
                if(logedUser.errorLogin>= Tools.Constants.LogTryes) 
                {
                    logedUser.isLocked = true;
                }
                //save user to db increasing one the tryes
                UserContext context = HttpContext.RequestServices.GetService(typeof(UserContext)) as UserContext;
                context.UpdateAsync(logedUser);
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
