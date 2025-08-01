using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
	public class IletisimController : Controller
	{
		Context c = new Context();

		[HttpGet]
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(iletisim i)
		{
			c.iletisims.Add(i); // İletisims = DbSet<Iletisim>
			c.SaveChanges();
			
			ViewBag.Mesaj = "Mesajınız gönderildi. Geri bildiriminiz için teşekkür ederiz.";

			ModelState.Clear(); // <-- bu satır tüm inputları temizler
			return View();
		}
	}
}
