using ConceptAcademy01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptAcademy01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Suneel1()
        {
            List<Student> stList = new List<Student>()
            {
                new Student {ID = 1, Name = "Suneel", Age= 22 },
                new Student {ID = 2, Name = "Santosh", Age = 18 },
                new Student {ID = 3, Name = "Jai", Age = 13 }
            };

            return View(stList);
        }

        public ActionResult Suneel()
        {
            List<string> name = new List<string>();
            name.Add("Suneel");
            name.Add("Santosh");
            name.Add("Muaaz");
            ViewBag.name = name;
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
    }
}