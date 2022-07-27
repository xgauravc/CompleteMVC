using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using MVCJqueryDemo.Models;

namespace MVCJqueryDemo.Controllers
    
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetStudent() {

            Student student = new Student() { 
            Id =1,
            Name="Gaurav"
            };
            var json = JsonConvert.SerializeObject(student);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}