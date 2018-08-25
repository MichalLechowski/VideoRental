﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
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