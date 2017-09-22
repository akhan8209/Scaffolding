using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Scaffolding_With_Area_in_Mvc;

namespace Scaffolding_With_Area_in_Mvc.Areas.A_Driver.Models
{
    public class DRIVERsController : Controller
    {
        private RideSharingDbEntities db = new RideSharingDbEntities();

        // GET: A_Driver/DRIVERs
        public ActionResult Index()
        {
            return View(db.DRIVERs.ToList());
        }

        // GET: A_Driver/DRIVERs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DRIVER dRIVER = db.DRIVERs.Find(id);
            if (dRIVER == null)
            {
                return HttpNotFound();
            }
            return View(dRIVER);
        }

        // GET: A_Driver/DRIVERs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: A_Driver/DRIVERs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DriverID,DriverName,DriverPassword,DriverContactNo,DriverLicenseNo")] DRIVER dRIVER)
        {
            if (ModelState.IsValid)
            {
                db.DRIVERs.Add(dRIVER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dRIVER);
        }

        // GET: A_Driver/DRIVERs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DRIVER dRIVER = db.DRIVERs.Find(id);
            if (dRIVER == null)
            {
                return HttpNotFound();
            }
            return View(dRIVER);
        }

        // POST: A_Driver/DRIVERs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DriverID,DriverName,DriverPassword,DriverContactNo,DriverLicenseNo")] DRIVER dRIVER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dRIVER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dRIVER);
        }

        // GET: A_Driver/DRIVERs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DRIVER dRIVER = db.DRIVERs.Find(id);
            if (dRIVER == null)
            {
                return HttpNotFound();
            }
            return View(dRIVER);
        }

        // POST: A_Driver/DRIVERs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DRIVER dRIVER = db.DRIVERs.Find(id);
            db.DRIVERs.Remove(dRIVER);
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
