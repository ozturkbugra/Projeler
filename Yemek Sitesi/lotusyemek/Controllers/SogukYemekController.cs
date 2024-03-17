using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using lotusyemek.Models;

namespace lotusyemek.Controllers
{
    public class SogukYemekController : Controller
    {
        private lotusEntities db = new lotusEntities();

        // GET: SogukYemek
        public ActionResult Index()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View(db.TblYemek4.OrderByDescending(x => x.ID).ToList());
        }

        // GET: SogukYemek/Create
        public ActionResult Create()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View();
        }

        // POST: SogukYemek/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ad,resim,aciklama")] TblYemek4 tblYemek4, HttpPostedFileBase resim)
        {
            if (ModelState.IsValid)
            {
                if (resim != null) // buradan logonun dolu olup olmadığını kontrol ediyoruz
                {

                    WebImage img = new WebImage(resim.InputStream); //bu ikisi resim ekleme
                    FileInfo imginfo = new FileInfo(resim.FileName);

                    string logoname = Guid.NewGuid().ToString() + imginfo.Extension; //resim adlandırma
                    img.Resize(1000, 1000);  // resim boyutu
                    img.Save("~/Uploads/SogukYemek/" + logoname);
                    tblYemek4.resim = "/Uploads/SogukYemek/" + logoname;


                }
                db.TblYemek4.Add(tblYemek4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblYemek4);
        }

        // GET: SogukYemek/Edit/5
        public ActionResult Edit(short? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblYemek4 tblYemek4 = db.TblYemek4.Find(id);
            if (tblYemek4 == null)
            {
                return HttpNotFound();
            }
            return View(tblYemek4);
        }

        // POST: SogukYemek/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ad,resim,aciklama")] TblYemek4 tblYemek4, HttpPostedFileBase resim, int id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (ModelState.IsValid)
            {
                var s = db.TblYemek4.Where(x => x.ID == id).SingleOrDefault();
                if (resim != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(s.resim))) //daha önce kaydettiğimiz dosya varsa silme kodu
                    {
                        System.IO.File.Delete(Server.MapPath(s.resim));
                    }


                    WebImage img = new WebImage(resim.InputStream); //bu ikisi resim ekleme
                    FileInfo imginfo = new FileInfo(resim.FileName);

                    string logoname = Guid.NewGuid().ToString() + imginfo.Extension; //resim adlandırma
                    img.Resize(1000, 1000);  // resim boyutu
                    img.Save("~/Uploads/SogukYemek/" + logoname);
                    s.resim = "/Uploads/SogukYemek/" + logoname;
                }
                s.ad = tblYemek4.ad;
                s.aciklama = tblYemek4.aciklama;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblYemek4);
        }

        // GET: SogukYemek/Delete/5
        public ActionResult Delete(short? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblYemek4 tblYemek4 = db.TblYemek4.Find(id);
            if (tblYemek4 == null)
            {
                return HttpNotFound();
            }
            return View(tblYemek4);
        }

        // POST: SogukYemek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            TblYemek4 tblYemek4 = db.TblYemek4.Find(id);
            if (System.IO.File.Exists(Server.MapPath(tblYemek4.resim))) //daha önce kaydettiğimiz dosya varsa silme kodu
            {
                System.IO.File.Delete(Server.MapPath(tblYemek4.resim));
            }
            db.TblYemek4.Remove(tblYemek4);
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
