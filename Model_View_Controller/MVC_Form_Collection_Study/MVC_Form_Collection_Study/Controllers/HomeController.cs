﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Form_Collection_Study.Controllers
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
        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(FormCollection formCollection)
        {
            if (ModelState.IsValid)
                foreach (string key in formCollection)
                {
                    Response.Write("key =" + key + " ");
                    Response.Write("Value = " + formCollection[key]);
                    Response.Write("<br/>");
                }
            return View();
        }
    }
}