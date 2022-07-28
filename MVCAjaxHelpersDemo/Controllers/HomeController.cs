using MVCAjaxHelpersDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

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

        public ActionResult List() {
            return View();
        }

        public JsonResult Countries()
        {
            List<string> countries = new List<string>() { 
                "Afghanistan", "Bangladesh","Bhutan","India","Iran","Maldives","Nepal","Pakistan","Sri Lanka"};
            var json = JsonConvert.SerializeObject(countries);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult States()
        {
            List<string> states = new List<string>() {
                "Andhra Pradesh","Arunachal Pradesh","Assam","Bihar","Chhattisgarh","Goa",  "Gujarat","Haryana","Himachal Pradesh","Jharkhand","Maharashtra"};
            var json = JsonConvert.SerializeObject(states);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        public JsonResult Cities()
        {
            List<string> cities = new List<string>() {
                "New Delhi","Delhi","Mumbai","Hyderabad","Bangalore","Chennai","Kolkata","Lucknow","Jaipur","Patna","Bhopal","Visakhapatnam","Srinagar","Chandigarh","Ranchi","Bhubaneshwar","Thiruvananthapuram","Raipur","Dehra Dun","Aizawl","Puducherry","Imphal","Ghandinagar","Agartala","Pathankot","Shimla","Shillong","Port Blair","Kohima"};
            var json = JsonConvert.SerializeObject(cities);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}
	

