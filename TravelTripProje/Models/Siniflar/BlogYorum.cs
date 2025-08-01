using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
	public class BlogYorum
	{

		// Tüm bloglar veya detay sayfasında gösterilecek blog

		public IEnumerable<Blog> Deger1 { get; set; }
		


		// Seçili bloga ait yorumlar

		public IEnumerable<Yorumlar> Deger2 { get; set; }

		// En güncel 5 blog
		public IEnumerable<Blog> Deger3 { get; set; }


		// En son 5 yorum (tüm bloglardan)
		public IEnumerable<Yorumlar> Deger4 { get; set; }
	}
}