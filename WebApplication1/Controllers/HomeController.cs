﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
        public ActionResult Detail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Categoryall()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ListingGirl()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ListingLarge()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}