using lotusyemek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lotusyemek.Controllers
{
    public class HomeController : Controller
    {
        private lotusEntities db = new lotusEntities();
        public ActionResult Index()
        {
            ViewBag.Message = TempData["Message"] as string;
            ViewBag.ErrorMessage = TempData["ErrorMessage"] as string;
            DateTime time = DateTime.Now.Date;
            var a = db.MenuViews.Where(x => x.tarih == time).FirstOrDefault();
            return View(a);
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult FoodMenu()
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            var menuForMonth = db.MenuViews
                .Where(x => x.tarih >= firstDayOfMonth && x.tarih <= lastDayOfMonth)
                .OrderBy(x=> x.tarih).ToList();

            return View(menuForMonth);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "adsoyad,mail,tel,aciklama,durum")] TblMesaj mesaj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.TblMesajs.Add(mesaj);
                    db.SaveChanges();
                    TempData["Message"] = "Mesajınız alındı, en kısa sürede sizinle iletişime geçeceğiz.";
                    return RedirectToAction("Index");
                }

                return View(mesaj);
            }
            catch (Exception)
            {

                TempData["ErrorMessage"] = "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.";
                return RedirectToAction("Index"); // Hata durumunda bir başka sayfaya yönlendirme yapabilirsiniz.
            }
            
        }

    }
}