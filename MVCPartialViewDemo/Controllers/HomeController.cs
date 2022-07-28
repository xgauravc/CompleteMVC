using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPartialViewDemo.Models;

namespace MVCPartialViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>() 
            {
            new Employee(){Name="Gaurav",Department="Engg",Designation= "SE",Role="Full Stack Developer" },
            new Employee(){Name="Gaurav",Department="Engg",Designation= "SE",Role="Full Stack Developer" }
            };
            return View(employees);
        }
    }
}