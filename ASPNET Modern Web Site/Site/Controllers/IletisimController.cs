using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class IletisimController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: Iletisim
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Iletisims.FirstOrDefault()); 
        }

        [HttpPost]
        public ActionResult UpdateIletisim(Iletisim tur)
        {
            var asd = db.Iletisims.Find(tur.Id);
            asd.Adres = tur.Adres;
            asd.Instagram = tur.Instagram;
            asd.Linkedin = tur.Linkedin;
            asd.Tel = tur.Tel;
            asd.Mail = tur.Mail;
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        public JsonResult GetIletisimById(int id)
        {
            var Tur = db.Iletisims.Find(id);
            return Json(Tur, JsonRequestBehavior.AllowGet);
        }
    }
}