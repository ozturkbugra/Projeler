using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class ProjeController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();
        // GET: Projeler
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();
            List<Tur> turlers = db.Turs.ToList();
            ViewBag.Tur = new SelectList(turlers, "Id", "TurAdi");
            return View(db.ProjelerViews.ToList());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddProje(Projeler proje, HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3, HttpPostedFileBase file4, HttpPostedFileBase file5)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/projeresim/"), fileName);
                    file.SaveAs(path);

                    proje.Resim1 = "/uploads/projeresim/" + fileName;
                }
                if (file1 != null && file1.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file1.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/projeresim/"), fileName);
                    file1.SaveAs(path);

                    proje.Resim2 = "/uploads/projeresim/" + fileName;
                }
                if (file2 != null && file2.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file2.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/projeresim/"), fileName);
                    file2.SaveAs(path);

                    proje.Resim3 = "/uploads/projeresim/" + fileName;
                }
                if (file3 != null && file3.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file3.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/projeresim/"), fileName);
                    file3.SaveAs(path);

                    proje.Resim4 = "/uploads/projeresim/" + fileName;
                }
                if (file4 != null && file4.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file4.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/projeresim/"), fileName);
                    file4.SaveAs(path);

                    proje.Resim5 = "/uploads/projeresim/" + fileName;
                }
                if (file5 != null && file5.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file4.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/projeresim/"), fileName);
                    file5.SaveAs(path);

                    proje.Resim6 = "/uploads/projeresim/" + fileName;
                }

                db.Projelers.Add(proje);
                db.SaveChanges();
            }


            return RedirectToAction("Index");
        }

        public JsonResult GetProjeById(int id)
        {
            var referrr = db.Projelers.Find(id);
            return Json(referrr, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UpdateProje(Projeler refe)
        {
            if (ModelState.IsValid)
            {
                var existingKullanici = db.Projelers.Find(refe.Id);
                if (existingKullanici != null)
                {

                    // Diğer kullanıcı bilgilerini güncelle
                    existingKullanici.Ad = refe.Ad;
                    existingKullanici.Aciklama = refe.Aciklama;
                    existingKullanici.ProjeURL = refe.ProjeURL;
                    existingKullanici.VideoURL = refe.VideoURL;
                    existingKullanici.Tur = refe.Tur;
                    existingKullanici.YayindaMi = refe.YayindaMi;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteProje(int id)
        {

            var kullaniciToRemove = db.Projelers.Find(id);
            if (kullaniciToRemove != null)
            {
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim1))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim1));
                }
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim2))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim2));
                }
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim3))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim3));
                }
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim4))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim4));
                }
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim5))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim5));
                }
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim6))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim6));
                }
                db.Projelers.Remove(kullaniciToRemove);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}