﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 20,Location = System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult GetDate()
        {
            return View();
        }
    }
}