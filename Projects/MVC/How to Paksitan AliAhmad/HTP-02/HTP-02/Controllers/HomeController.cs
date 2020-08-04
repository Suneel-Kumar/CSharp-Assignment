using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTP_02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(tbl_Category category)
        {
            WebAppDbContext db = new WebAppDbContext();
            db.tbl_Category.Add(category);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            WebAppDbContext db = new WebAppDbContext();
            var list = db.tbl_Category.ToList();
            return View(list);
        }

    }
}