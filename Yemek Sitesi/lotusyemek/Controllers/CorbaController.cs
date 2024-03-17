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
    public class CorbaController : Controller
    {
        private lotusEntities db = new lotusEntities();

        // GET: Corba
        public ActionResult Index()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View(db.TblYemek1.OrderByDescending(x => x.ID).ToList());
        }


        // GET: Corba/Create
        public ActionResult Create()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View();
        }

        // POST: Corba/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ad,resim,aciklama")] TblYemek1 tblYemek1, HttpPostedFileBase resim)
        {
            if (ModelState.IsValid)
            {
                if (resim != null) // buradan logonun dolu olup olmadığını kontrol ediyoruz
                {

                    WebImage img = new WebImage(resim.InputStream); //bu ikisi resim ekleme
                    FileInfo imginfo = new FileInfo(resim.FileName);

                    string logoname = Guid.NewGuid().ToString() + imginfo.Extension; //resim adlandırma
                    img.Resize(1000, 1000);  // resim boyutu
                    img.Save("~/Uploads/Corba/" + logoname);
                    tblYemek1.resim = "/Uploads/Corba/" + logoname;


                }
                db.TblYemek1.Add(tblYemek1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblYemek1);
        }

        // GET: Corba/Edit/5
        public ActionResult Edit(short? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblYemek1 tblYemek1 = db.TblYemek1.Find(id);
            if (tblYemek1 == null)
            {
                return HttpNotFound();
            }
            return View(tblYemek1);
        }

        // POST: Corba/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ad,resim,aciklama")] TblYemek1 tblYemek1, HttpPostedFileBase resim, int id)
        {
            if (ModelState.IsValid)
            {
                var s = db.TblYemek1.Where(x => x.ID == id).SingleOrDefault();
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
                    img.Save("~/Uploads/Corba/" + logoname);
                    s.resim = "/Uploads/Corba/" + logoname;
                }
                s.ad = tblYemek1.ad;
                s.aciklama = tblYemek1.aciklama;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblYemek1);
        }

        // GET: Corba/Delete/5
        public ActionResult Delete(short? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblYemek1 tblYemek1 = db.TblYemek1.Find(id);
            if (tblYemek1 == null)
            {
                return HttpNotFound();
            }
            return View(tblYemek1);
        }

        // POST: Corba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            TblYemek1 tblYemek1 = db.TblYemek1.Find(id);
            if (System.IO.File.Exists(Server.MapPath(tblYemek1.resim))) //daha önce kaydettiğimiz dosya varsa silme kodu
            {
                System.IO.File.Delete(Server.MapPath(tblYemek1.resim));
            }
            db.TblYemek1.Remove(tblYemek1);
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
