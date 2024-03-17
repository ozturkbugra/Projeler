using lotusyemek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace lotusyemek.Controllers
{
    public class AdminController : Controller
    {

        private lotusEntities db = new lotusEntities();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Corba = db.TblYemek1.Count();
            ViewBag.AnaYemek = db.TblYemek2.Count();
            ViewBag.YardimciYemek = db.TblYemek3.Count();
            ViewBag.SogukYemek = db.TblYemek4.Count();
            ViewBag.Sayi = db.TblMesajs.Count();
            ViewBag.Mesaj = db.TblMesajs.OrderByDescending(x => x.ID).ToList();
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TblAdmin admin)
        {

           
            var l = db.TblAdmins.Where(x => x.kadi == admin.kadi && x.sifre == admin.sifre ).SingleOrDefault();

            if (l != null)
            {
                // Kullanıcı doğrulandı, oturumu başlat
                Session["adminid"] = l.ID;
                Session["kullaniciadi"] = l.kadi;
                Session["parola"] = l.sifre;
                

                return RedirectToAction("Index", "Admin");
            }

            // Kullanıcı adı veya parola yanlış ise uyarı mesajı görüntüle
            ViewBag.Uyari = "Kullanıcı adı veya şifre yanlış";
            return View();

        }

        public ActionResult Logout()
        {
            Session["adminid"] = null;
            Session["kullaniciadi"] = null;
            Session["parola"] = null;
            Session.Abandon();

            return RedirectToAction("Login", "Admin");

        }

    }
}