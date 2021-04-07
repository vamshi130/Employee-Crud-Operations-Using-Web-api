using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeUI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult Create()
        {        
            return View();
        }
        
    }
}