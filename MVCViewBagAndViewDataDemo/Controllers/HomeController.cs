using MVCViewBagAndViewDataDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewBagAndViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee{ EmpId =1, EmpName = "Gaurav", Department ="Engg"},
                new Employee{ EmpId =2, EmpName = "Saurav", Department ="Engg"},
                new Employee{ EmpId =3, EmpName = "Kaurav", Department ="Engg"}


            };
            ViewData["empList1"] = employees;

            ViewBag.empList = employees;
            return View();
        }
    }
}