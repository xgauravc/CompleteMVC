using MVCHtmlHempersDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHempersDemo.Controllers
{
    public class StronglyTypedDemoController : Controller
    {
        List<Employee> employees = new List<Employee>();
        // GET: StronglyTypedDemo

        //Model(property)+ View(HTML) = strongly typed view
        public ActionResult Index()
        {
            Employee emp = new Employee() { EmpId = 1, EmpName = "Gaurav", Department = "Engg", IsEmployee = true };
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            employees.Add(emp);


            return View();
        }
    }
}