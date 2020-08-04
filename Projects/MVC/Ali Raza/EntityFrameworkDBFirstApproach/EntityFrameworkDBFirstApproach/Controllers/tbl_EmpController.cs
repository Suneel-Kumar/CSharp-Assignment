using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkDBFirstApproach;

namespace EntityFrameworkDBFirstApproach.Controllers
{
    public class tbl_EmpController : Controller
    {
        private MVC_Concept_AcademyEntities db = new MVC_Concept_AcademyEntities();

        // GET: tbl_Emp
        public ActionResult Index()
        {
            return View(db.tbl_Emp.ToList());
        }

        // GET: tbl_Emp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Emp tbl_Emp = db.tbl_Emp.Find(id);
            if (tbl_Emp == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Emp);
        }

        // GET: tbl_Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Emp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Emp_ID,Emp_Name,Emp_Age")] tbl_Emp tbl_Emp)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Emp.Add(tbl_Emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Emp);
        }

        // GET: tbl_Emp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Emp tbl_Emp = db.tbl_Emp.Find(id);
            if (tbl_Emp == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Emp);
        }

        // POST: tbl_Emp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Emp_ID,Emp_Name,Emp_Age")] tbl_Emp tbl_Emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Emp);
        }

        // GET: tbl_Emp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Emp tbl_Emp = db.tbl_Emp.Find(id);
            if (tbl_Emp == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Emp);
        }

        // POST: tbl_Emp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Emp tbl_Emp = db.tbl_Emp.Find(id);
            db.tbl_Emp.Remove(tbl_Emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
