using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcEF6ContactManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Contact Manager application using ASP.NET MVC and Entity Framework 6";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the Developer";

            return View();
        }
    }
}