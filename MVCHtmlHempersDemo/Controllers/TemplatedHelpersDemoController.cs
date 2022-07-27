using MVCHtmlHempersDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHempersDemo.Controllers
{
    public class TemplatedHelpersDemoController : Controller
    {
        // GET: TemplatedHelpersDemo
        //Templated HTML helpers are used for :

        //Display
        


        //Edit / Input
        public ActionResult Index()
        {
            Employee employee = new Employee() { 
            EmpId = 1,
            EmpName ="Gaurav",
            DOB = DateTime.Now,
            IsEmployee = true,
            Department ="Engg"
            };
            return View(employee);
        }
        public ActionResult Edit() {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
    }
}