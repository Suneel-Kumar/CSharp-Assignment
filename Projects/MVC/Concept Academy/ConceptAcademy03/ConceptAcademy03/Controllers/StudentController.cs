using ConceptAcademy03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptAcademy03.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            DB_ConceptAcademyEntities db = new DB_ConceptAcademyEntities();
            List<Student> StList = db.Students.ToList();
            StudentModal stModal = new StudentModal();
            List<StudentModal> stViewList = StList.Select(x => new StudentModal
            {
                Std_ID = x.Std_ID,
                Std_Name = x.Std_Name,
                Std_Age = x.Std_Age,
                Dept_Name = x.tbl_Dept.Dept_Name
                
            }).ToList();


            return View(stViewList);
        }
    }
}
