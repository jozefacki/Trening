using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4.Models;

namespace MVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            using (var db = new UserContext())
            {
                db.Users.Add(new UserViewModel
                {
                    FirstName = "Kasia",
                    LastName = "Hoppe",
                    Gender = true
                });
            }
            //db.SaveChanges();
            
            return View();
        }
    }
}