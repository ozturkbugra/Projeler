using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class ReferanslarController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: Referanslar
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Referanslars.ToList());
        }

        [HttpPost]
        public ActionResult AddReferans(Referanslar refe, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/referanslar/"), fileName);
                    file.SaveAs(path);

                    refe.Resim = "/uploads/referanslar/" + fileName;
                }
                db.Referanslars.Add(refe);
                db.SaveChanges();
            }

           
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult UpdateReferans(Referanslar refe, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                var existingKullanici = db.Referanslars.Find(refe.Id);
                if (existingKullanici != null)
                {
                    // Eski resmi silme
                    if (file != null && file.ContentLength > 0 && !string.IsNullOrEmpty(existingKullanici.Resim))
                    {
                        var imagePath = Server.MapPath(existingKullanici.Resim);
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    // Yeni resmi kaydetme (eğer yeni bir resim seçilmişse)
                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        var path = Path.Combine(Server.MapPath("/uploads/referanslar/"), fileName);
                        file.SaveAs(path);

                        existingKullanici.Resim = "/uploads/referanslar/" + fileName;
                    }

                    // Diğer referans bilgilerini güncelle
                    existingKullanici.Ad = refe.Ad;
                    db.SaveChanges();
                }
            }
            
            return RedirectToAction("Index");
        }




        public JsonResult GetReferansById(int id)
        {
            var referrr = db.Referanslars.Find(id);
            return Json(referrr, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteReferans(int id)
        {

            var kullaniciToRemove = db.Referanslars.Find(id);
            if (kullaniciToRemove != null)
            {
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim));
                }
                db.Referanslars.Remove(kullaniciToRemove);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}