using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lotusyemek.Models;

namespace lotusyemek.Controllers
{
    public class TblMesajController : Controller
    {
        private lotusEntities db = new lotusEntities();

        // GET: TblMesaj
        public ActionResult Index()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View(db.TblMesajs.OrderByDescending(x=> x.ID).ToList());
        }

        // GET: TblMesaj/Details/5
        public ActionResult Details(int? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblMesaj tblMesaj = db.TblMesajs.Find(id);
            if (tblMesaj == null)
            {
                return HttpNotFound();
            }
            return View(tblMesaj);
        }

        // GET: TblMesaj/Create
        public ActionResult Create()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View();
        }

        // POST: TblMesaj/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,adsoyad,mail,tel,aciklama,durum")] TblMesaj tblMesaj)
        {
            if (ModelState.IsValid)
            {
                db.TblMesajs.Add(tblMesaj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblMesaj);
        }

        // GET: TblMesaj/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblMesaj tblMesaj = db.TblMesajs.Find(id);
            if (tblMesaj == null)
            {
                return HttpNotFound();
            }
            return View(tblMesaj);
        }

        // POST: TblMesaj/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,adsoyad,mail,tel,aciklama,durum")] TblMesaj tblMesaj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMesaj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblMesaj);
        }

        // GET: TblMesaj/Delete/5
        public ActionResult Delete(int? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblMesaj tblMesaj = db.TblMesajs.Find(id);
            if (tblMesaj == null)
            {
                return HttpNotFound();
            }
            return View(tblMesaj);
        }

        // POST: TblMesaj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblMesaj tblMesaj = db.TblMesajs.Find(id);
            db.TblMesajs.Remove(tblMesaj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
