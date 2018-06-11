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
    public class MenuCategoryEntitiesController : Controller
    {
        private PokeDbContext db = new PokeDbContext();

        // GET: MenuCategoryEntities
        public ActionResult Index()
        {
            return View(db.MenuCategories.ToList());
        }

        // GET: MenuCategoryEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuCategoryEntity menuCategoryEntity = db.MenuCategories.Find(id);
            if (menuCategoryEntity == null)
            {
                return HttpNotFound();
            }
            return View(menuCategoryEntity);
        }

        // GET: MenuCategoryEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuCategoryEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Category,ImgUrl,ItemAddonHeading,Shop1RefId,Shop2RefId")] MenuCategoryEntity menuCategoryEntity)
        {
            if (ModelState.IsValid)
            {
                db.MenuCategories.Add(menuCategoryEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuCategoryEntity);
        }

        // GET: MenuCategoryEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuCategoryEntity menuCategoryEntity = db.MenuCategories.Find(id);
            if (menuCategoryEntity == null)
            {
                return HttpNotFound();
            }
            return View(menuCategoryEntity);
        }

        // POST: MenuCategoryEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Category,ImgUrl,ItemAddonHeading,Shop1RefId,Shop2RefId")] MenuCategoryEntity menuCategoryEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuCategoryEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuCategoryEntity);
        }

        // GET: MenuCategoryEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuCategoryEntity menuCategoryEntity = db.MenuCategories.Find(id);
            if (menuCategoryEntity == null)
            {
                return HttpNotFound();
            }
            return View(menuCategoryEntity);
        }

        // POST: MenuCategoryEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuCategoryEntity menuCategoryEntity = db.MenuCategories.Find(id);
            db.MenuCategories.Remove(menuCategoryEntity);
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
