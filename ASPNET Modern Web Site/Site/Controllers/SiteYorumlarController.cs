using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class SiteYorumlarController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: SiteYorumlar
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Yorumlars.ToList());
        }

        [HttpPost]
        public ActionResult AddYorum(Yorumlar yorum, HttpPostedFileBase Resim)
        {
            if (ModelState.IsValid)
            {
                
                if (Resim != null && Resim.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Resim.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/yorum/"), fileName);
                    Resim.SaveAs(path);

                    yorum.Resim = "/uploads/yorum/" + fileName;
                }
                db.Yorumlars.Add(yorum);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteYorum(int id)
        {

            var kullaniciToRemove = db.Yorumlars.Find(id);
            if (kullaniciToRemove != null)
            {
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim));
                }
                db.Yorumlars.Remove(kullaniciToRemove);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult UpdateYorum(Yorumlar refe, HttpPostedFileBase Resim)
        {
            if (ModelState.IsValid)
            {
                var existingKullanici = db.Yorumlars.Find(refe.Id);
                if (existingKullanici != null)
                {
                    // Eski resmi silme
                    if (Resim != null && Resim.ContentLength > 0 && !string.IsNullOrEmpty(existingKullanici.Resim))
                    {
                        var imagePath = Server.MapPath(existingKullanici.Resim);
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    // Yeni resmi kaydetme (eğer yeni bir resim seçilmişse)
                    if (Resim != null && Resim.ContentLength > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Resim.FileName);
                        var path = Path.Combine(Server.MapPath("/uploads/yorum/"), fileName);
                        Resim.SaveAs(path);

                        existingKullanici.Resim = "/uploads/yorum/" + fileName;
                    }

                    // Diğer kullanıcı bilgilerini güncelle
                    existingKullanici.Ad = refe.Ad;
                    existingKullanici.Aciklama = refe.Aciklama;
                    existingKullanici.Unvan = refe.Unvan;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }


        public JsonResult GetYorumById(int id)
        {
            var referrr = db.Yorumlars.Find(id);
            return Json(referrr, JsonRequestBehavior.AllowGet);
        }
    }
}