using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class YetenekController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: Yetenek
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Yeteneklers.ToList());
        }

        [HttpPost]
        public ActionResult AddYetenekler(Yetenekler kat)
        {
            db.Yeteneklers.Add(kat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateYetenekler(Yetenekler kat)
        {

            var a = db.Yeteneklers.Find(kat.Id);
            if (a != null)
            {
                a.Adi = kat.Adi;
                a.Renk = kat.Renk;
                a.Yuzdesi = kat.Yuzdesi;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteYetenekler(int id)
        {
            var asd = db.Yeteneklers.Find(id);
            db.Yeteneklers.Remove(asd);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public JsonResult GetYeteneklerById(int id)
        {
            var kate = db.Yeteneklers.Find(id);
            return Json(kate, JsonRequestBehavior.AllowGet);
        }
    }
}