using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EFDBFirstApproach;

namespace EFDBFirstApproach.Controllers
{
    public class tbl_EmpsController : Controller
    {
        private MVC_Concept_AcademyEntities db = new MVC_Concept_AcademyEntities();

        // GET: tbl_Emps
        public ActionResult Index()
        {
            var tbl_Emps = db.tbl_Emps.Include(t => t.tbl_Dept);
            return View(tbl_Emps.ToList());
        }

        // GET: tbl_Emps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Emps tbl_Emps = db.tbl_Emps.Find(id);
            if (tbl_Emps == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Emps);
        }

        // GET: tbl_Emps/Create
        public ActionResult Create()
        {
            ViewBag.Emp_FK_Dept_ID = new SelectList(db.tbl_Dept, "Dept_Id", "Dept_Name");
            return View();
        }

        // POST: tbl_Emps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Emp_ID,Emp_Name,Emp_Age,Emp_FK_Dept_ID")] tbl_Emps tbl_Emps)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Emps.Add(tbl_Emps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Emp_FK_Dept_ID = new SelectList(db.tbl_Dept, "Dept_Id", "Dept_Name", tbl_Emps.Emp_FK_Dept_ID);
            return View(tbl_Emps);
        }

        // GET: tbl_Emps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Emps tbl_Emps = db.tbl_Emps.Find(id);
            if (tbl_Emps == null)
            {
                return HttpNotFound();
            }
            ViewBag.Emp_FK_Dept_ID = new SelectList(db.tbl_Dept, "Dept_Id", "Dept_Name", tbl_Emps.Emp_FK_Dept_ID);
            return View(tbl_Emps);
        }

        // POST: tbl_Emps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Emp_ID,Emp_Name,Emp_Age,Emp_FK_Dept_ID")] tbl_Emps tbl_Emps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Emps).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Emp_FK_Dept_ID = new SelectList(db.tbl_Dept, "Dept_Id", "Dept_Name", tbl_Emps.Emp_FK_Dept_ID);
            return View(tbl_Emps);
        }

        // GET: tbl_Emps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Emps tbl_Emps = db.tbl_Emps.Find(id);
            if (tbl_Emps == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Emps);
        }

        // POST: tbl_Emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Emps tbl_Emps = db.tbl_Emps.Find(id);
            db.tbl_Emps.Remove(tbl_Emps);
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
