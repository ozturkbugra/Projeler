using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class HakkimdaController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();

        // GET: Hakkimda
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Hakkimdas.FirstOrDefault());
        }



        [HttpPost]
        public ActionResult UpdateHakkimda(Hakkimda tur)
        {
            var asd = db.Hakkimdas.Find(tur.Id);
            asd.Yazi = tur.Yazi;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

     

        public JsonResult GetHakkimizdaById(int id)
        {
            var Tur = db.Hakkimdas.Find(id);
            return Json(Tur, JsonRequestBehavior.AllowGet);
        }


    }
}