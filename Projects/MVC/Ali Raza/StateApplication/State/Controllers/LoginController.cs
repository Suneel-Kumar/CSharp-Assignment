using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace State.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtname,  string txtpassword)
        {
            //two Types Cookie  1) Persistance 2)NonPersistance(Close Browser vanish)
            if(txtname == "suneel" && txtpassword == "suneel11")
            {
                HttpCookie cookie = new HttpCookie("Data", "Suneel");
                cookie.Expires = DateTime.Now.AddSeconds(40);
                Response.Cookies.Add(cookie);

                //Response.Cookies["User"].Value = "Last";
                return RedirectToAction("Index", "Auth");
            }
            else
            {
                return View();
            }
        }
    }
}