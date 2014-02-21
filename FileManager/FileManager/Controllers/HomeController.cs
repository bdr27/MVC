using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileManager.Models;

namespace FileManager.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            /*foreach (var user in UserQueries.GetUsers())
            {
                Console.WriteLine(user.User_Username);
            }*/
            return View();
        }

        [HttpPost]
        public ActionResult LoginCheck()
        {
            var userLogin = new UserLogin();
            //userLogin.Username = Request.Form["username"];
            //userLogin.Password = Request.Form["password"];
            if (UserQueries.ValidCredentials(Request.Form["username"], Request.Form["password"]) != null)
            {
                Console.WriteLine("YAY");
            }
            return View();
        }
    }
}
