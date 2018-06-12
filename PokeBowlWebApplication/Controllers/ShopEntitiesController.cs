using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PokeBowlWebApplication;
using PokeBowlWebApplication.Models.Dto;

namespace PokeBowlWebApplication.Controllers
{
    public class ShopEntitiesController : Controller
    {
        private PokeDbContext db = new PokeDbContext();

        // GET: ShopEntities
        public ActionResult Index()
        {
            return View(db.Shops.ToList());
        }

        // GET: ShopEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopEntity shopEntity = db.Shops.Find(id);
            if (shopEntity == null)
            {
                return HttpNotFound();
            }
            return View(shopEntity);
        }

        // GET: ShopEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone")] ShopEntity shopEntity)
        {
            if (ModelState.IsValid)
            {
                db.Shops.Add(shopEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopEntity);
        }

        // GET: ShopEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopEntity shopEntity = db.Shops.Find(id);
            if (shopEntity == null)
            {
                return HttpNotFound();
            }
            return View(shopEntity);
        }

        // POST: ShopEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone")] ShopEntity shopEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopEntity);
        }

        // GET: ShopEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopEntity shopEntity = db.Shops.Find(id);
            if (shopEntity == null)
            {
                return HttpNotFound();
            }
            return View(shopEntity);
        }

        // POST: ShopEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShopEntity shopEntity = db.Shops.Find(id);
            db.Shops.Remove(shopEntity);
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
