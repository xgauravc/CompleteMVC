using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCVControllerDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index() {
            return "This is string from index view";
        }
        public ViewResult Home() {
            return View();
        }
        public DateTime Date() {
            return DateTime.Now;
        }
    }
}