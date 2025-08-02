using System.Linq;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
	public class OtelController : Controller
	{
		Context c = new Context();

		public ActionResult Index()
		{
			var oteller = c.Otels.ToList();
			return View(oteller);
		}

		public ActionResult OtelEkle()
		{
			ViewBag.Bloglar = new SelectList(c.Blogs.ToList(), "BlogId", "Baslik");
			return View();
		}

		[HttpPost]
		public ActionResult OtelEkle(Otel o)
		{
			c.Otels.Add(o);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
