using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtname, int pass)
        {
            if(txtname == "Suneel" && pass == 123)
            {
                Session["Data"] = "Ali";
                //HttpCookie Ck = new HttpCookie("Data", "We");
                //Response.Cookies.Add(Ck);
                //Ck.Expires = DateTime.Now.AddSeconds(30);
                //Response.Cookies["Data"].Value = "Suneel";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Log()
        {
            Session.Remove("Data");
            return View("Index");
        }

    }
}