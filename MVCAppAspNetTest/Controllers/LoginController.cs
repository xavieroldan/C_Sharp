using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAppAspNetTest.Clases;
using MVCAppAspNetTest.Models;
using MVCAppAspNetTest.Tools;
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
            LoginModel loggedUser = new LoginModel();
            List<LoginModel> listUsers = new List<LoginModel>();
            int logTryes = 0;
            bool isPresentUser = false;

            user.userid = 0;
            user.name = HttpContext.Request.Form["name"];
            user.password = HttpContext.Request.Form["pass"];
            user.errorLogin = 0;
            user.isLocked = false;

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
                    //user exists
                    isPresentUser = true;
                    loggedUser = item;
                }
            }
            

            if (isPresentUser && user.name == loggedUser.name && user.password == loggedUser.password)
            {                
                //Is logged correctly
                if(loggedUser.isLocked)
                {
                    //Locked                    
                    ViewData["MessageLocked"] = "The user "+ user.name + " is now locked.";
                    return View("LockedUser");
                }
                else
                {
                    //Logged correctly
                    //update db : reset logged tries
                    loggedUser.errorLogin = 0;
                    UserContext context = HttpContext.RequestServices.GetService(typeof(UserContext)) as UserContext;
                    await context.UpdateAsync(loggedUser);
                    ViewData["MessageLoggedOk"] = loggedUser.name + " => Welcome to the system";
                    MailSender mailSender = new MailSender();
                    mailSender.sendEmail();
                    return View("FirstScreen");
                }                
            }
            else
            {
                //increasing one the login error tries
                loggedUser.errorLogin++;
                //Is locked now? =>Update user
                if(loggedUser.errorLogin>= Tools.Constants.LogTryes) 
                {
                    loggedUser.isLocked = true;                    
                }
                //save user to db increasing one the tries
                UserContext context = HttpContext.RequestServices.GetService(typeof(UserContext)) as UserContext;
                await context.UpdateAsync(loggedUser);
                if (loggedUser.isLocked) 
                {
                    ViewData["MessageLocked"] = "The user " + user.name + " is now locked.";
                    return View("LockedUser"); 
                }
                else 
                {
                    ViewData["MessageErrorLogin"] = "Keep! Error number " + loggedUser.errorLogin + " trying login.";
                    return View("ErrorLogin"); 
                }                
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
