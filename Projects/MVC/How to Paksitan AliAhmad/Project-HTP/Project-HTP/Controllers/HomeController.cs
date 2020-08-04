using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_HTP.Controllers
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
        public ActionResult Login(tbl_User AuthUser)
        {
            WebAppDbContext db = new WebAppDbContext();
            var user = db.tbl_User.Where(x => x.Name == AuthUser.Name && x.Password == AuthUser.Password).FirstOrDefault();
            if (user != null)
            {
                return View("Index");
            }
            else {

                return View("ListView");
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(tbl_User User)
        {
            WebAppDbContext db = new WebAppDbContext();
            db.tbl_User.Add(User);
            db.SaveChanges();

            return View("Index");
        }

        public ActionResult ListView()
        {
            WebAppDbContext db = new WebAppDbContext();
            var list = db.tbl_User.ToList();

            return View(list);
        }
    }
}