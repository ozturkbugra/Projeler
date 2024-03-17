using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lotusyemek.Models;

namespace lotusyemek.Controllers
{
    public class MenuController : Controller
    {
        private lotusEntities db = new lotusEntities();

        // GET: Menu
        public ActionResult Index()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View(db.MenuViews.OrderByDescending(x=> x.Menü_No).ToList());
        }

        // GET: Menu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuView menuView = db.MenuViews.Find(id);
            if (menuView == null)
            {
                return HttpNotFound();
            }
            return View(menuView);
        }

        // GET: Menu/Create
        public ActionResult Create()
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            List<TblYemek1> yemekListesi = db.TblYemek1.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri = yemekListesi
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri = yemekSecenekleri;


            List<TblYemek2> yemekListesi2 = db.TblYemek2.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri2 = yemekListesi2
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri2 = yemekSecenekleri2;

            List<TblYemek3> yemekListesi3 = db.TblYemek3.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri3 = yemekListesi3
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri3 = yemekSecenekleri3;

            List<TblYemek4> yemekListesi4 = db.TblYemek4.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri4 = yemekListesi4
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri4 = yemekSecenekleri4;


            // Diğer işlemler veya View çağrısı
            return View();
           
        }
   
        // POST: Menu/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,yemek1,yemek2,yemek3,yemek4,tarih")] TblMenu tblMenu)
        {
            if (ModelState.IsValid)
            {
                db.TblMenus.Add(tblMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblMenu);
        }

        // GET: Menu/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblMenu tblMenu = db.TblMenus.Find(id);
            List<TblYemek1> yemekListesi = db.TblYemek1.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri = yemekListesi
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri = yemekSecenekleri;


            List<TblYemek2> yemekListesi2 = db.TblYemek2.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri2 = yemekListesi2
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri2 = yemekSecenekleri2;

            List<TblYemek3> yemekListesi3 = db.TblYemek3.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri3 = yemekListesi3
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri3 = yemekSecenekleri3;

            List<TblYemek4> yemekListesi4 = db.TblYemek4.ToList();

            // SelectListItem listesi oluştur
            List<SelectListItem> yemekSecenekleri4 = yemekListesi4
                .Select(y => new SelectListItem
                {
                    Value = y.ID.ToString(), // Id'yi değer olarak kullan
                    Text = y.ad // Gösterilen adı text olarak kullan
                })
                .ToList();

            // ViewBag ile View'e gönder
            ViewBag.YemekSecenekleri4 = yemekSecenekleri4;
            if (tblMenu == null)
            {
                return HttpNotFound();
            }
            return View(tblMenu);
        }

        // POST: Menu/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,yemek1,yemek2,yemek3,yemek4,tarih")] TblMenu tblMenu)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            if (ModelState.IsValid)
            {
                db.Entry(tblMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblMenu);
        }

        // GET: Menu/Delete/5
        public ActionResult Delete(int? id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuView menuView = db.MenuViews.Find(id);
            if (menuView == null)
            {
                return HttpNotFound();
            }
            return View(menuView);
        }

        // POST: Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            TblMenu tblMenu = db.TblMenus.Find(id);
            db.TblMenus.Remove(tblMenu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
