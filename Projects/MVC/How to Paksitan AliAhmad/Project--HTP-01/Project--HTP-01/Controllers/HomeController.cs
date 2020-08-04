using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project__HTP_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_User User)
        {
            WebAppEntities db = new WebAppEntities();
            var user = db.tbl_User.Where(x => x.Name == User.Name && x.Password == User.Password).Count();
            if(user == 1)
            {
                return View("Index");
            }
            else
            {
                return View("List");
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tbl_User User)
        {
            WebAppEntities db = new WebAppEntities();
            db.tbl_User.Add(User);
            db.SaveChanges();
            return View("List");
        }

        public ActionResult List()
        {
            WebAppEntities db = new WebAppEntities();
            var list = db.tbl_User.ToList();
            return View(list);
        }
    }
}