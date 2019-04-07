using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VicLyfe.Models;

namespace VicLyfe.Controllers
{
    public class User_Current_LocationController : Controller
    {
        private Model1 db = new Model1();

        // GET: User_Current_Location
        public ActionResult Index()
        {
            return View(db.User_Current_Location.ToList());
        }

        // GET: User_Current_Location/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Current_Location user_Current_Location = db.User_Current_Location.Find(id);
            if (user_Current_Location == null)
            {
                return HttpNotFound();
            }
            return View(user_Current_Location);
        }

        // GET: User_Current_Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User_Current_Location/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Time,Latitude,Longitude,Filter_1,Filter_2,Filter_3,Filter_4,Filter_5,Filter_6")] User_Current_Location user_Current_Location)
        {
            if (ModelState.IsValid)
            {
                db.User_Current_Location.Add(user_Current_Location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_Current_Location);
        }

        // GET: User_Current_Location/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Current_Location user_Current_Location = db.User_Current_Location.Find(id);
            if (user_Current_Location == null)
            {
                return HttpNotFound();
            }
            return View(user_Current_Location);
        }

        // POST: User_Current_Location/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Time,Latitude,Longitude,Filter_1,Filter_2,Filter_3,Filter_4,Filter_5,Filter_6")] User_Current_Location user_Current_Location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_Current_Location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_Current_Location);
        }

        // GET: User_Current_Location/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Current_Location user_Current_Location = db.User_Current_Location.Find(id);
            if (user_Current_Location == null)
            {
                return HttpNotFound();
            }
            return View(user_Current_Location);
        }

        // POST: User_Current_Location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            User_Current_Location user_Current_Location = db.User_Current_Location.Find(id);
            db.User_Current_Location.Remove(user_Current_Location);
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
