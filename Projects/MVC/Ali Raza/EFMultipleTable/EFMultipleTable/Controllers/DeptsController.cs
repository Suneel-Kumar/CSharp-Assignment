using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EFMultipleTable;

namespace EFMultipleTable.Controllers
{
    public class DeptsController : Controller
    {
        private AliRazaMVCEntities db = new AliRazaMVCEntities();

        // GET: Depts
        public ActionResult Index()
        {
            var depts = db.Depts.Include(d => d.Employee);
            return View(depts.ToList());
        }

        // GET: Depts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dept dept = db.Depts.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }

        // GET: Depts/Create
        public ActionResult Create()
        {
            ViewBag.Emp_Dept = new SelectList(db.Employees, "emp_Id", "emp_Name");
            return View();
        }

        // POST: Depts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Dept_Id,Dept_Name,Emp_Dept")] Dept dept)
        {
            if (ModelState.IsValid)
            {
                db.Depts.Add(dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Emp_Dept = new SelectList(db.Employees, "emp_Id", "emp_Name", dept.Emp_Dept);
            return View(dept);
        }

        // GET: Depts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dept dept = db.Depts.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            ViewBag.Emp_Dept = new SelectList(db.Employees, "emp_Id", "emp_Name", dept.Emp_Dept);
            return View(dept);
        }

        // POST: Depts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Dept_Id,Dept_Name,Emp_Dept")] Dept dept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Emp_Dept = new SelectList(db.Employees, "emp_Id", "emp_Name", dept.Emp_Dept);
            return View(dept);
        }

        // GET: Depts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dept dept = db.Depts.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }

        // POST: Depts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dept dept = db.Depts.Find(id);
            db.Depts.Remove(dept);
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
