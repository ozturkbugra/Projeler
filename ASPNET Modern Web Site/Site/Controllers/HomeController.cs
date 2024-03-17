using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class HomeController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        public ActionResult Index()
        {

            string ipAddress = Request.UserHostAddress;
            DateTime currentDate = DateTime.Now;

            bool kullanicivarmi = db.VisitorLogs.Any(x => x.IPAddress == ipAddress);
            if (!kullanicivarmi)
            {
                ViewBag.a = true;
            }
            else
            {
                ViewBag.a = false;
            }

            // Aynı IP adresi için aynı gün içinde kayıt var mı kontrol et
            bool isDuplicate = db.VisitorLogs.Any(v => v.IPAddress == ipAddress && v.VisitDate == currentDate.Date);

            if (!isDuplicate)
            {
                // Aynı IP adresi için aynı gün içinde kayıt yoksa kaydet
                VisitorLog newVisitorLog = new VisitorLog
                {
                    IPAddress = ipAddress,
                    VisitDate = currentDate,
                    Day = currentDate.Day,
                    Month = currentDate.Month,
                    Year = currentDate.Year
                };
                
                db.VisitorLogs.Add(newVisitorLog);
                db.SaveChanges();
            }
            

            

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
                .ToList();

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
                .ToList();

            db.SaveChanges();

            ViewBag.Yorumlar = db.Yorumlars.ToList();
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();
            ViewBag.WebYayinda = db.Projelers.Where(x => x.YayindaMi == "A").Count();
            ViewBag.Referans = db.Referanslars.ToList();
            ViewBag.ToplamReferans = db.Referanslars.Count();
            ViewBag.ToplamProje = db.Projelers.Count();
            ViewBag.Blog = db.BloglarViews.Take(3).OrderByDescending(x => x.Id).ToList();
            ViewBag.ProjeTur = db.Turs.ToList();
            ViewBag.Projeler = db.ProjelerViews.ToList();
            ViewBag.YorumTalebiAlindi2 = TempData["durum2"];
            ViewBag.YorumTalebiAlindi3 = TempData["durum3"];

            ViewBag.YorumSayilari = db.Yorumlars.Count();
            ViewBag.BlogSayilari = db.BloglarViews.Count();


            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            return View();
        }

        public ActionResult Hakkimda()
        {
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();
            return View();
        }

        public ActionResult Bloglarim(string q)
        {
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();
            ViewBag.BlogTur = db.Kategorilers.ToList();
            
            
            if (!string.IsNullOrEmpty(q))
            {
                ViewBag.Blog = db.BloglarViews
             .Where(b => b.Baslik.Contains(q) || b.Aciklama.Contains(q))
             .OrderByDescending(x => x.Id)
             .ToList();
            }
            else
            {
                // Eğer boş değer varsa, tüm blogları getirin
                ViewBag.Blog = db.BloglarViews.OrderByDescending(x => x.Id).ToList();
            }



            return View();
        }

        public ActionResult BlogDetay(int? id, Bloglar b)
        {
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();

            try
            {
                var blog = db.BloglarViews.SingleOrDefault(x => x.Id == id);
                ViewBag.YorumSayi = db.BlogYorumlarViews.Where(x => x.Expr1 == id && x.Durum == "1").Count();
                if (blog == null)
                {
                    // Eşleşen proje bulunamadı, hata mesajı ile birlikte "Index" ekrana yönlendir.

                    return RedirectToAction("Index");
                }

                var blogToUpdate = db.Bloglars.SingleOrDefault(x => x.Id == id);
                if (blogToUpdate != null)
                {
                    blogToUpdate.Click++;
                    db.SaveChanges(); // Bu satır eklenmiş oldu
                }
                ViewBag.Kategoriler = db.Kategorilers.ToList();
                ViewBag.Yorumlar = db.BlogYorumYenis.Where(x => x.BlogID == id && x.YorumDurum == "1").ToList();
                ViewBag.Yorumlar5 = db.BlogYorumlarViews.Where(x => x.Expr1 == id && x.Durum == "1" && x.YanitVerildiMi == "h").ToList();
                ViewBag.Yorumsayi = db.BlogYorumlarViews.Where(x => x.Expr1 == id && x.Durum == "1").Count();
                ViewBag.BloglarTop = db.BloglarViews.Take(5).OrderByDescending(x => x.Click).ToList();
                ViewBag.Bloglar = db.BloglarViews.Take(5).OrderByDescending(x => x.Id).ToList();
                ViewBag.YorumTalebiAlindi = TempData["durum"];
                return View(blog);
            }
            catch (Exception ex)
            {
                // Hata olursa yine "Index" ekrana yönlendir.

                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public ActionResult AddYorum(BlogYorumlar by)
        {
            try
            {
                by.Durum = "0";
                by.Tarih = DateTime.Now;
                by.OkunduMu = "a";
                by.YanitVerildiMi = "h";
                db.BlogYorumlars.Add(by);
                db.SaveChanges();
                TempData["durum"] = true;
                return RedirectToAction("BlogDetay", new { id = by.BlogId });
            }
            catch (Exception)
            {
                return RedirectToAction("BlogDetay", new { id = by.BlogId });

            }
           

        }

        [HttpPost]
        public ActionResult AddMesaj(Mesajlar msj)
        {
            try
            {
                msj.OkunduMu = "a";
                msj.Tarih = DateTime.Now;
             
                db.Mesajlars.Add(msj);
                db.SaveChanges();
                TempData["durum2"] = true;
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                TempData["durum3"] = true;
                return RedirectToAction("Index");
            }
            

        }


        public ActionResult Projelerim(string q)
        {
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();

            if (!string.IsNullOrEmpty(q))
            {
                ViewBag.Projeler = db.ProjelerViews
             .Where(b => b.Ad.Contains(q) || b.Aciklama.Contains(q))
             .OrderByDescending(x => x.Id)
             .ToList();
            }
            else
            {
                // Eğer boş değer varsa, tüm blogları getirin
                ViewBag.Projeler = db.ProjelerViews.ToList();
            }

            ViewBag.ProjeTur = db.Turs.ToList();
            
            return View();
        }

        public ActionResult ProjeDetay(int? id)
        {
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            try
            {
                var proje = db.ProjelerViews.SingleOrDefault(x => x.Id == id);

                if (proje == null)
                {
                    // Eşleşen proje bulunamadı, hata mesajı ile birlikte "Index" ekrana yönlendir.
                  
                    return RedirectToAction("Index");
                }

                return View(proje);
            }
            catch (Exception ex)
            {
                // Hata olursa yine "Index" ekrana yönlendir.
               
                return RedirectToAction("Index");
            }


        }

        public ActionResult Referanslarim()
        {
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            ViewBag.Iletisim = db.Iletisims.SingleOrDefault();

            ViewBag.Referans = db.Referanslars.ToList();
            return View();
        }

        public PartialViewResult Footer() {
            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            return PartialView();
        }
    }
}