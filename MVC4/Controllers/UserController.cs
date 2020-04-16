using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4.Models;

namespace MVC4.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewUser() // obsługuje widok
        {
            return View();
        }
        [HttpPost]  //dane z formularzy pobieramy postem
        public ActionResult NewUser(UserViewModel newUser)
        {
            return View();
        }
    }
}