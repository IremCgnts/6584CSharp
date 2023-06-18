using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC11SessionController : Controller
    {
        // GET: MVC11Seesion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SessionOlustur(string kullaniciAdi, string sifre)
        {
            {
                if(kullaniciAdi=="Admin" && sifre=="1234")// eğer ekrandan gönderilen değerler admin ve 1234 ise 
                {
                    Session["deger"] = "Admin";// Bir session oluştur adı deger olsun  ve üzerinde admin verisini taşısın.
                   TempData["mesaj"] = "<div class=' alert alert-success'>Giriş Başarılı!</div>"; 
                }
                else
                {
                    TempData["mesaj"] = "<div class=' alert alert-danger'>Giriş Başarısız!</div>";
                }
            }
            return View("Index");
        }
        public ActionResult SessionOku()
        {
            if (Session["deger"] !=null)
            {
                TempData["mesaj"] =$"<div class=' alert alert-success'>Hoşgeldin{Session["deger"]}</div>";
            }
            else
            {
                TempData["mesaj"] = "<div class=' alert alert-danger'>Giriş Yapılmadı!</div>";
            }
            return View();
        }
        public ActionResult SessionSil()
        {
            if (Session["deger"]!=null)
            {
                HttpContext.Session.Remove("deger");
            }
            return RedirectToAction("Index");
        }
        public ActionResult KullaniciEkrani()
        {
            if (Session["deger"] == null)
                return RedirectToAction("Index");
            return View();
        }
    }
}