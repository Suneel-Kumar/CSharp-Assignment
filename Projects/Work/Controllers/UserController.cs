using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uname, string password)
        {
            User us = new User();
            us.Name = uname;
            us.Password = password;
            Session["uname"] = uname;
            if (us.Check())
                return RedirectToAction("Create", "User");
            else
                return RedirectToAction("Index", "User");

        }

        //HttpPost]
        public ActionResult Logout()
        {
            Session.Remove("uname");
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            if (Session["uname"] != null)
            {
                return View();
            }
            return RedirectToAction("Index", "User");
        }


    }
}
