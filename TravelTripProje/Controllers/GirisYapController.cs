using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        //http post = veri gönderme - butona tıklama varsa tetiklenir

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == ad.KullaniciAdi && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString(); // Kullanıcı adını oturumda sakla
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Hata = "Kullanıcı adı veya şifre yanlış!";
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut(); // Oturumu kapat
            //Session.Clear(); // Tüm oturum verilerini temizle
            return RedirectToAction("Login", "GirisYap"); // Giriş sayfasına yönlendir
        }
    }
}