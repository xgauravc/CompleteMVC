using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTempDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["myKey"] = "Data from index 1";
            
            return View();
        }public ActionResult Index2()
        {
            TempData.Keep("myKey"); //keeps specific key for next http request cycle
            //TempData.Keep(); //keeps all keys for next http request cycle
            return View();
        }public ActionResult Index3()
        {
            return View();
        }public ActionResult Index4()
        {
            return View();
        }public ActionResult Index5()
        {
            return View();
        }
    }
}