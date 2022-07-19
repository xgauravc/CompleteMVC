using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHempersDemo.Controllers
{
    public class BuiltInHelpersDemoController : Controller
    {
        // GET: Home2
        public ActionResult Index(string name=null)
        {
            return View();
        }
    }
}