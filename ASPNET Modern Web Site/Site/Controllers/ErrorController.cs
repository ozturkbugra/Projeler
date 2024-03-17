using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class ErrorController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        public ActionResult PageNotFound()
        {
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




            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            // Burada özel bir hata sayfasını görüntüleyebilirsiniz
            return View();
        }

        public ActionResult Forbidden()
        {
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




            ViewBag.Iletisim2 = db.Iletisims.SingleOrDefault();
            ViewBag.Hakkimda2 = db.Hakkimdas.SingleOrDefault();
            ViewBag.Proje2 = db.Projelers.Take(10).OrderByDescending(x => x.Id).ToList();
            ViewBag.Yetenek2 = db.Yeteneklers.OrderByDescending(x => x.Yuzdesi).ToList();
            // Burada 403.14 hatası için özel bir hata sayfasını görüntüleyebilirsiniz
            return View();
        }
    }
}