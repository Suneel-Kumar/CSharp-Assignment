using ConceptAcademy02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptAcademy02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult StudentModalEF(int ID)
        {
            ConceptAcademyEntities db = new ConceptAcademyEntities();
            tbl_Student tbSt = db.tbl_Student.SingleOrDefault(x => x.Std_Id == ID);
            StModal modal1 = new StModal();
            modal1.Std_Id = tbSt.Std_Id;
            modal1.Std_Name = tbSt.Std_Name;
            modal1.Std_Age = tbSt.Std_Age;

            return View(modal1);
        }

        public ActionResult Index12()
        {
            List<StModal> St_List = new List<StModal>()
            {
                new StModal {ID = 1,  Name = "Ali", Age = 34},
                new StModal {ID = 2, Name = "Muaaz", Age = 22 },
                new StModal {ID = 3, Name = "Hamza", Age = 24 },
                new StModal {ID = 4, Name = "Rafay", Age = 25 }
            };
            return View(St_List);
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
    }
}