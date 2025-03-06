﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayStudyGroupProfiles.Controllers
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

        public ActionResult Static()
        {
            //getting prev url from request headers
            string refererURL = Request.UrlReferrer?.ToString();

            //passing url to view
            ViewBag.RefererURL = refererURL ?? Url.Action("Index", "Home"); //fallback

            return View();
        }
    }
}