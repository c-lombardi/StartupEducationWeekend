using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartupEducationWeekend.Models;

namespace StartupEducationWeekend.Controllers
{
    public class CollegesController : Controller
    {
        private StartUpEducationWeekendContext db = new StartUpEducationWeekendContext();

        //
        // GET: /Colleges/

        public ActionResult Index()
        {
            return View(db.Colleges.ToList());
        }

        //
        // GET: /Colleges/Details/5

        public ActionResult Details(int id = 0)
        {
            Colleges colleges = db.Colleges.Find(id);
            if (colleges == null)
            {
                return HttpNotFound();
            }
            return View(colleges);
        }

        //
        // GET: /Colleges/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Colleges/Create

        [HttpPost]
        public ActionResult Create(Colleges colleges)
        {
            if (ModelState.IsValid)
            {
                db.Colleges.Add(colleges);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colleges);
        }

        //
        // GET: /Colleges/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Colleges colleges = db.Colleges.Find(id);
            if (colleges == null)
            {
                return HttpNotFound();
            }
            return View(colleges);
        }

        //
        // POST: /Colleges/Edit/5

        [HttpPost]
        public ActionResult Edit(Colleges colleges)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colleges).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colleges);
        }

        //
        // GET: /Colleges/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Colleges colleges = db.Colleges.Find(id);
            if (colleges == null)
            {
                return HttpNotFound();
            }
            return View(colleges);
        }

        //
        // POST: /Colleges/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Colleges colleges = db.Colleges.Find(id);
            db.Colleges.Remove(colleges);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}