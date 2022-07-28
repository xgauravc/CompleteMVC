using MVCAjaxHelpersDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxHelpersDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Employee employee)
        {
            return Json(employee,JsonRequestBehavior.AllowGet);
        }
    }
}