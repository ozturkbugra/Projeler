using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class YetkiliController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: Yetkili
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Admins.ToList());
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin admin, string Sifre)
        {


            admin.Sifre = Crypto.Hash(Sifre, "MD5");

            // Check if the user with the same username already exists
            if (db.Admins.Any(a => a.KullaniciAdi == admin.KullaniciAdi))
            {
                return Json(new { success = false});
            }
            else
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return Json(new { success = true});
            }



        }



        public ActionResult UpdateAdmin(Admin kat, string Sifre)
        {

            var a = db.Admins.Find(kat.Id);
            if (a != null)
            {
                a.AdSoyad = kat.AdSoyad;
                a.KullaniciAdi = kat.KullaniciAdi;
                a.Sifre = Crypto.Hash(Sifre, "MD5");
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public JsonResult GetAdminById(int id)
        {
            var referrr = db.Admins.Find(id);
            return Json(referrr, JsonRequestBehavior.AllowGet);
          
        }

        [HttpPost]
        public ActionResult DeleteAdmin(int id)
        {

            var kullaniciToRemove = db.Admins.Find(id);
            if (kullaniciToRemove != null)
            {
                db.Admins.Remove(kullaniciToRemove);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}