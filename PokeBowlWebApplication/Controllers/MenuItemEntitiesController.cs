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
    public class MenuItemEntitiesController : Controller
    {
        private PokeDbContext db = new PokeDbContext();

        // GET: MenuItemEntities
        public ActionResult Index()
        {
            var menuItems = db.MenuItems.Include(m => m.MenuCategory);
            return View(menuItems.ToList());
        }

        // GET: MenuItemEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItemEntity menuItemEntity = db.MenuItems.Find(id);
            if (menuItemEntity == null)
            {
                return HttpNotFound();
            }
            return View(menuItemEntity);
        }

        // GET: MenuItemEntities/Create
        public ActionResult Create()
        {
            ViewBag.MenuCategoryRefId = new SelectList(db.MenuCategories, "Id", "Category");
            return View();
        }

        // POST: MenuItemEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Heading,Description,Price,ImgUrl,MenuCategoryRefId")] MenuItemEntity menuItemEntity)
        {
            if (ModelState.IsValid)
            {
                db.MenuItems.Add(menuItemEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MenuCategoryRefId = new SelectList(db.MenuCategories, "Id", "Category", menuItemEntity.MenuCategoryRefId);
            return View(menuItemEntity);
        }

        // GET: MenuItemEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItemEntity menuItemEntity = db.MenuItems.Find(id);
            if (menuItemEntity == null)
            {
                return HttpNotFound();
            }
            ViewBag.MenuCategoryRefId = new SelectList(db.MenuCategories, "Id", "Category", menuItemEntity.MenuCategoryRefId);
            return View(menuItemEntity);
        }

        // POST: MenuItemEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Heading,Description,Price,ImgUrl,MenuCategoryRefId")] MenuItemEntity menuItemEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuItemEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MenuCategoryRefId = new SelectList(db.MenuCategories, "Id", "Category", menuItemEntity.MenuCategoryRefId);
            return View(menuItemEntity);
        }

        // GET: MenuItemEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItemEntity menuItemEntity = db.MenuItems.Find(id);
            if (menuItemEntity == null)
            {
                return HttpNotFound();
            }
            return View(menuItemEntity);
        }

        // POST: MenuItemEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuItemEntity menuItemEntity = db.MenuItems.Find(id);
            db.MenuItems.Remove(menuItemEntity);
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
