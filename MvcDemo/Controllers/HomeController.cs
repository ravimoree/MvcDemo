using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            if (UserName == "admin" && Password == "admin")
            {
                return RedirectToAction("Country");
            }
            else
            {
                return View();
            }
        }
        public ActionResult ShabasadMaster()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }

    }
}