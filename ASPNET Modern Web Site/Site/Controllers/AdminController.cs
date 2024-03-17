using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class AdminController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities(); 
        // GET: Admin
        public ActionResult Index()
        {
            DateTime currentDate = DateTime.Now;

            // Günlük ziyaretçi sayısını al
            var dailyVisitorCounts = db.VisitorLogs
                .Where(v => v.Day == currentDate.Day && v.Month == currentDate.Month && v.Year == currentDate.Year)
                .Count();

            // Aylık ziyaretçi sayısını al
            var monthlyVisitorCounts = db.VisitorLogs
                .Where(v => v.Month == currentDate.Month && v.Year == currentDate.Year)
                .GroupBy(v => v.Day)
                .Select(g => new
                {
                    Day = g.Key,
                    Count = g.Count()
                })
                .Sum(g => g.Count);

            // Yıllık ziyaretçi sayısını al
            var yearlyVisitorCounts = db.VisitorLogs
                .Where(v => v.Year == currentDate.Year)
                .GroupBy(v => new { v.Month, v.Day })
                .Select(g => new
                {
                    Month = g.Key.Month,
                    Day = g.Key.Day,
                    Count = g.Count()
                })
                .Sum(g => g.Count);

            ViewBag.GunSayi = dailyVisitorCounts;
            ViewBag.AySayi = monthlyVisitorCounts;
            ViewBag.YilSayi = yearlyVisitorCounts;
            ViewBag.MesajSayi2 = db.Mesajlars.Count(); 
            ViewBag.BlogYorum = db.BlogYorumlars.Where(x=> x.Durum == "1").Count();
            ViewBag.SiteMesajSayi = db.Yorumlars.Count();
            ViewBag.YetenekSayi = db.Yeteneklers.Count();
            ViewBag.ProjeSayi = db.Projelers.Count();
            ViewBag.ReferansSayi = db.Referanslars.Count();
            ViewBag.BlogSayi = db.Bloglars.Count();

            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x=>x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x=> x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            return View();
        }

        [HttpPost]
        public ActionResult MarkAllAsRead()
        {
            try
            {
                // Bütün yorumları okundu olarak işaretle
                foreach (var item in db.BlogYorumlars)
                {
                    item.OkunduMu = "p";
                }

                db.SaveChanges(); // Değişiklikleri kaydet

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "İşlem tamamlanamadı." });
            }
        }
        
        [HttpPost]
        public ActionResult MarkAllAsRead2()
        {
            try
            {
                // Bütün yorumları okundu olarak işaretle
                foreach (var item in db.Mesajlars)
                {
                    item.OkunduMu = "p";
                }

                db.SaveChanges(); // Değişiklikleri kaydet

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "İşlem tamamlanamadı." });
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult IP()
        {

            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.VisitorLogs.OrderByDescending(x=> x.ID).ToList());

        }


        [HttpPost]
        public ActionResult Login(Admin admin, string Sifre)
        {
            var s = Crypto.Hash(Sifre, "MD5");
            var l = db.Admins.Where(x => x.KullaniciAdi == admin.KullaniciAdi && x.Sifre == s).SingleOrDefault();

            if (l != null)
            {
                // Kullanıcı doğrulandı, oturumu başlat
                Session["adminid"] = l.Id;
                Session["kullaniciadi"] = l.KullaniciAdi;
                Session["AdSoyad"] = l.AdSoyad;

                // Beni hatırla seçeneği işaretlenmişse cookie oluştur
               
                    HttpCookie authCookie = new HttpCookie("AdminCookie");
                    authCookie.Values["adminid"] = l.Id.ToString();
                    authCookie.Values["kullaniciadi"] = l.KullaniciAdi;
                    authCookie.Values["AdSoyad"] = l.AdSoyad;

                    // Cookie'nin süresini isteğe bağlı olarak ayarlayabilirsiniz
                    authCookie.Expires = DateTime.Now.AddDays(7); // Örnek olarak 7 gün

                    Response.Cookies.Add(authCookie);
                

                return RedirectToAction("Index");
            }

            ViewBag.Uyari = "Kullanıcı adı veya şifre yanlış";
            return View();
        }

        public ActionResult Logout()
        {
            // Oturumu sonlandır
            Session["adminid"] = null;
            Session["kullaniciadi"] = null;
            Session["AdSoyad"] = null;
            Session.Abandon();

            // Cookie'yi kontrol et ve varsa sil
            if (Request.Cookies["AdminCookie"] != null)
            {
                HttpCookie adminCookie = new HttpCookie("AdminCookie");
                adminCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(adminCookie);
            }

            return RedirectToAction("Login", "Admin");
        }


        public ActionResult Mesaj()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            return View(db.Mesajlars.ToList());
        }

        public ActionResult Tur()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            return View(db.Turs.ToList());
        }

        [HttpPost]
        public ActionResult AddTur(Tur tur)
        {
            db.Turs.Add(tur);
            db.SaveChanges();
      
            return RedirectToAction("Tur");
        }

        [HttpPost]
        public ActionResult UpdateTur(Tur tur)
        {
            var asd = db.Turs.Find(tur.Id);
            asd.TurAdi = tur.TurAdi;
            db.SaveChanges();
            
            return RedirectToAction("Tur");
        }

        [HttpPost]
        public ActionResult DeleteTur(int id)
        {
           
            bool canDelete = !db.Projelers.Any(p => p.Tur == id);

            if (canDelete)
            {
                var sil = db.Turs.Find(id);
                db.Turs.Remove(sil);
                db.SaveChanges();
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }

        }

        public JsonResult GetTurById(int id)
        {
            var Tur = db.Turs.Find(id);
            return Json(Tur, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult DeleteMesajlar(int id)
        {
            var sil1 = db.Mesajlars.Find(id);
            db.Mesajlars.Remove(sil1);
            db.SaveChanges();

            return RedirectToAction("Mesaj");

        }
       

    }
}