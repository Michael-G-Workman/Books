using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Books.DAL;
using Books.Models;

namespace Books.Controllers
{
    public class TitlesController : Controller
    {
        private BooksContext db = new BooksContext();

        // GET: Titles
        public ActionResult Index()
        {
            var titles = db.Titles.ToList();

            return View(titles);
        }

        // GET: Titles/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return HttpNotFound();
            }
            return View(title);
        }

        // GET: Titles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Titles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate")] Title singleTitle)
        {
            if (ModelState.IsValid)
            {
                db.Titles.Add(singleTitle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(singleTitle);
        }

        // GET: Titles/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Title singleTitle = db.Titles.Find(id);
            if (singleTitle == null)
            {
                return HttpNotFound();
            }
            return View(singleTitle);
        }

        // POST: Titles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate")] Title singleTitle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(singleTitle).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(singleTitle);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Edit Title Action: Error: " + ex.Message;
                ViewBag.InnerException = "Inner Exception: " + ex.InnerException;
                return View("TitleError");
            }
        }

        // GET: Titles/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Title singleTitle = db.Titles.Find(id);
            if (singleTitle == null)
            {
                return HttpNotFound();
            }
            return View(singleTitle);
        }

        // POST: Titles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Title singleTitle = db.Titles.Find(id);
            db.Titles.Remove(singleTitle);
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
