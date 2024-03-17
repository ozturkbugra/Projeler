using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class KategoriController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: Kategori
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Kategorilers.ToList());
        }


        [HttpPost]
        public ActionResult AddKategori(Kategoriler kat)
        {
            db.Kategorilers.Add(kat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateKategori(Kategoriler kat)
        {
            var a = db.Kategorilers.Find(kat.Id);
            a.Ad = kat.Ad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteKategori(int id)
        {
            bool canDelete = !db.Bloglars.Any(p => p.Kategori == id);

            if (canDelete)
            {
                var asd = db.Kategorilers.Find(id);
                db.Kategorilers.Remove(asd);
                db.SaveChanges();
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
            
            

        }

        public JsonResult GetKategoriById(int id)
        {
            var kate = db.Kategorilers.Find(id);
            return Json(kate, JsonRequestBehavior.AllowGet);
        }
    }
}