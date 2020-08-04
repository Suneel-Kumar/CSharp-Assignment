using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class INFOController : Controller
    {
        // GET: INFO
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
                temp = info;
                TempData["info"] = "Hoga Add";
                TempData["data"] = info.Name;
                return RedirectToAction("Index", "Info");
            }
            TempData["info"] = "Nai Hoga";
            return RedirectToAction("Index", "Info");
        }
    }
}