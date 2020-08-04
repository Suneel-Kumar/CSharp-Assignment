using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        DBHandler db = new DBHandler();
        Info temp;
        [HttpPost]
        public ActionResult Create(Info info)
        {
            if (db.InsertInfo(info) > 0)
            {
                TempData["info"]= "Nhi Add Howa";
                return RedirectToAction("Index", "Info");
            }

            TempData["info"] = "Nhi Add Howa";
            return RedirectToAction("Index", "Info");
        }
    }
}