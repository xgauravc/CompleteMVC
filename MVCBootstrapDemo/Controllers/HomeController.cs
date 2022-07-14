using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBootstrapDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult SetTheme() {
        //    return View("About");
        //}
        [HttpPost]
        public ActionResult SetTheme(string data) 
        {

            //Create a Cookie with a suitable Key.
            HttpCookie nameCookie = new HttpCookie("theme");
            //Set the Cookie value.
            nameCookie.Values["theme"] = data;
            //Set the Expiry date.
            nameCookie.Expires = DateTime.Now.AddDays(1);
            //Add the Cookie to Browser.
            Response.Cookies.Add(nameCookie);


            return RedirectToAction("About");
        }
    }
}