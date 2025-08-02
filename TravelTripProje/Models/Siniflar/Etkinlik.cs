using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelTripProje.Models.Siniflar
{
	public class Etkinlik
	{
		[Key]
		public int EtkinlikId { get; set; }

		[Required]
		public string Baslik { get; set; }

		public string Aciklama { get; set; }

		public string Lokasyon { get; set; }  // Şehir, ülke veya detay

		public DateTime Tarih { get; set; }

		public string FotoUrl { get; set; }

		// Blog ile ilişkilendirmek istersen:
		public int? BlogId { get; set; }
		public virtual Blog Blog { get; set; }
	}
}
