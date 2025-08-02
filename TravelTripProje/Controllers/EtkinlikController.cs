using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
	public class EtkinlikController : Controller
	{
		Context c = new Context();

		// GET: Etkinlik
		public ActionResult Index()
		{
			var etkinlikler = c.Etkinliks.ToList();
			return View(etkinlikler);
		}

		// GET: EtkinlikEkle (Form Sayfası)
		[HttpGet]
		public ActionResult EtkinlikEkle()
		{
			ViewBag.Bloglar = new SelectList(c.Blogs.ToList(), "BlogId", "Baslik");
			return View();
		}

		// POST: EtkinlikEkle (Formdan gelen veriyi işle)
		[HttpPost]
		public ActionResult EtkinlikEkle(Etkinlik e)
		{
			c.Etkinliks.Add(e);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
