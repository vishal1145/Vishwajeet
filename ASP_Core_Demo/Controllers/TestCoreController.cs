using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Core_Demo.Models;
using System.Data;

namespace ASP_Core_Demo.Controllers
{
    public class TestCoreController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            string getdata = "select * from EmpDemo";
            DataTable dt = DBManager.ExecuterAddpter(getdata);
            return View(dt);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            string str = "insert into EmpDemo (Name,Address)Values('" + employee.Name + "','" + employee.Address + "')";
            DBManager.ExecuteQuery(str);

            return RedirectToAction("Index");
        }
    }
}