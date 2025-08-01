﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        [Authorize]
		public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
			return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
		}

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);//yeniblog cshtml dosyasından gelen veriyi p parametresine atar
			c.SaveChanges();
            return RedirectToAction("Index");
		}

        public ActionResult BlogSil(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
			return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
		}

        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Blogs.Find(b.Id);
            blog.Baslik = b.Baslik;
            blog.Aciklama = b.Aciklama;
            blog.Tarih = b.Tarih;
            blog.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
		}

        public ActionResult YorumlarListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
		}

		public ActionResult YorumSil(int id)
		{
			var b = c.Yorumlars.Find(id);
			c.Yorumlars.Remove(b);
			c.SaveChanges();
			return RedirectToAction("YorumlarListesi");
		}

		public ActionResult YorumGetir(int id)
		{
			var yr = c.Yorumlars.Find(id);
			return View("YorumGetir", yr);
		}

		public ActionResult YorumGuncelle(Yorumlar y)
		{
			var yrm = c.Yorumlars.Find(y.Id);
			yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;    
			c.SaveChanges();
			return RedirectToAction("YorumlarListesi");
		}
	}
}