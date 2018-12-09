using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VideoGameShop2.Models;

namespace VideoGameShop2.Controllers
{
    public class SellerListsController : Controller
    {
        private VideoGameShop2DB db = new VideoGameShop2DB();

        // GET: SellerLists
        public ActionResult Index()
        {
            return View(db.SellerLists.ToList());
        }

        // GET: SellerLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SellerList sellerList = db.SellerLists.Find(id);
            if (sellerList == null)
            {
                return HttpNotFound();
            }
            return View(sellerList);
        }

        // GET: SellerLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SellerLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sellerListID")] SellerList sellerList)
        {
            if (ModelState.IsValid)
            {
                db.SellerLists.Add(sellerList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sellerList);
        }

        // GET: SellerLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SellerList sellerList = db.SellerLists.Find(id);
            if (sellerList == null)
            {
                return HttpNotFound();
            }
            return View(sellerList);
        }

        // POST: SellerLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sellerListID")] SellerList sellerList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sellerList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sellerList);
        }

        // GET: SellerLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SellerList sellerList = db.SellerLists.Find(id);
            if (sellerList == null)
            {
                return HttpNotFound();
            }
            return View(sellerList);
        }

        // POST: SellerLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SellerList sellerList = db.SellerLists.Find(id);
            db.SellerLists.Remove(sellerList);
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
