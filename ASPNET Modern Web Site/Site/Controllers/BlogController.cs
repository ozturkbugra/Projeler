using BugraSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugraSite.Controllers
{
    public class BlogController : Controller
    {
        bugrasiteEntities db = new bugrasiteEntities();

        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            List<Kategoriler> categories = db.Kategorilers.ToList();
            ViewBag.Kategori = new SelectList(categories, "Id", "Ad");
            return View(db.BloglarViews.ToList());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddBlog(Bloglar blog, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                blog.Tarih = DateTime.Now;
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Server.MapPath("/uploads/blogresim/"), fileName);
                    file.SaveAs(path);

                    blog.Resim = "/uploads/blogresim/" + fileName;
                }
                db.Bloglars.Add(blog);
                db.SaveChanges();
            }


            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UpdateBlog(Bloglar refe, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                var existingKullanici = db.Bloglars.Find(refe.Id);
                if (existingKullanici != null)
                {
                    // Eski resmi silme
                    if (file != null && file.ContentLength > 0 && !string.IsNullOrEmpty(existingKullanici.Resim))
                    {
                        var imagePath = Server.MapPath(existingKullanici.Resim);
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    // Yeni resmi kaydetme (eğer yeni bir resim seçilmişse)
                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        var path = Path.Combine(Server.MapPath("/uploads/blogresim/"), fileName);
                        file.SaveAs(path);

                        existingKullanici.Resim = "/uploads/blogresim/" + fileName;
                    }

                    // Diğer kullanıcı bilgilerini güncelle
                    existingKullanici.Baslik = refe.Baslik;
                    existingKullanici.Aciklama = refe.Aciklama;
                    existingKullanici.Kategori = refe.Kategori;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }




        public JsonResult GetBlogById(int id)
        {
            var referrr = db.Bloglars.Find(id);
            return Json(referrr, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteBlog(int id)
        {

            var kullaniciToRemove = db.Bloglars.Find(id);
            if (kullaniciToRemove != null)
            {
                if (System.IO.File.Exists(Server.MapPath(kullaniciToRemove.Resim))) //daha önce kaydettiğimiz dosya varsa silme kodu
                {
                    System.IO.File.Delete(Server.MapPath(kullaniciToRemove.Resim));
                }
                db.Bloglars.Remove(kullaniciToRemove);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


      

        public ActionResult BlogYorum(int? id)
        {
            ViewBag.Mesaj = db.Mesajlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.MesajSayi = db.Mesajlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.MesajBildirim = db.Mesajlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

            ViewBag.Yorum = db.BlogYorumlars.Where(x => x.OkunduMu == "a").OrderByDescending(x => x.Id).ToList();
            ViewBag.YorumSayi = db.BlogYorumlars.Where(x => x.OkunduMu == "a").Count();
            ViewBag.YorumBildirim = db.BlogYorumlars.Where(x => x.OkunduMu == "p").OrderByDescending(x => x.Id).ToList();

           
            if (id == 0)
            {
                ViewBag.Baslik = "Onaylanmayan Yorumlar";
                var a = db.BlogYorumlarViews.Where(x => x.Durum == "0").OrderByDescending(x => x.Id).ToList();
                return View(a);

            }else
            {
                ViewBag.Baslik = "Onaylanan Yorumlar";
                var a = db.BlogYorumlarViews.Where(x => x.Durum == "1").OrderByDescending(x => x.Id).ToList();
                return View(a);
            }
            
        }

        [HttpPost]
        public ActionResult DeleteBlogYorumlar(int id)
        {

            var kullaniciToRemove = db.BlogYorumlars.Find(id);
            if (kullaniciToRemove != null)
            {
                db.BlogYorumlars.Remove(kullaniciToRemove);
                db.SaveChanges();
            }

            return RedirectToAction("BlogYorum");
        }

        [HttpPost]
        public ActionResult ApproveBlogComment(int id)
        {
            var blogComment = db.BlogYorumlars.Find(id);

            if (blogComment != null)
            {
                blogComment.Durum = "1"; // Onay durumunu 1 olarak güncelle
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false, message = "Yorum bulunamadı." });
        }


        [HttpPost]
        public ActionResult Yanitla(BlogYorumYanit by2, int id)
        {
            var asd = db.BlogYorumlars.Find(id);
            asd.YanitVerildiMi = "e";

            by2.BlogYorumId = id;
            by2.Tarih = DateTime.Now;
            db.BlogYorumYanits.Add(by2);
            db.SaveChanges();
        
            return RedirectToAction("BlogYorum", new { id = 1 });
        }
    }
}