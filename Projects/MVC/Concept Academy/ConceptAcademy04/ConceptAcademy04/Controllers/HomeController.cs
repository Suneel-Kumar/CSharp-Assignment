using ConceptAcademy04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptAcademy04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DropDown()
        {
            DB_ConceptAcademyEntities db = new DB_ConceptAcademyEntities();
            List<tbl_Dept> deptList = db.tbl_Dept.ToList();
            ViewBag.dept_List = new SelectList(deptList, "dept_ID", "dept_name");
            //ViewBag.dept_List = new SelectList(deptList, "dept_ID", "dept_name");

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Employee()
        {
            ViewBag.Message = "Employee Detail";

            DB_ConceptAcademyEntities db = new DB_ConceptAcademyEntities();
            List<tbl_Employee> emplist = db.tbl_Employee.ToList();
            Employee emp = new Employee();
            List<Employee> empli = emplist.Select(x => new Employee {
                Emp_ID = x.Emp_ID,
                Emp_Name = x.Emp_Name,
                Emp_Add = x.Emp_Add,
                Emp_Dept = x.tbl_Dept.dept_ID
            }).ToList();


            return View();
        }
    }
}