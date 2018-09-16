using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppVideoRental.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View("Contact");
        }
    }
}