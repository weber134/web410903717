﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410903717.Controllers
{
    public class waterController : Controller
    {
        // GET: water
        public ActionResult Index(string name, float? weight)
        {
            var result = "";
            if (weight.HasValue)
            {
                result = (weight * 30) + "cc";
            }
            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}