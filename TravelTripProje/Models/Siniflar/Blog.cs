using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
	public class Blog
	{
		[Key]
		public int Id { get; set; }
		public string Baslik { get; set; }
		public DateTime Tarih { get; set; }

		public string Aciklama { get; set; }
		public string BlogImage { get; set; }
		public ICollection<Yorumlar> Yorumlars { get; set; } // Bloga ait yorumları tutmak için - 1'e  çok ilişkisi

		//bir bloğun birden fazla yorumu olabilir, bu yüzden ICollection kullanıyoruz.

	}
}