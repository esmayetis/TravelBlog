﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
	public class Yorumlar
	{
		[Key]
		public int Id { get; set; }
		public string KullaniciAdi { get; set; }
		public string Mail { get; set; }
		
		public string Yorum { get; set; }

		public int BlogId { get; set; } // Yorumun hangi bloga ait olduğunu belirtmek için
		public virtual Blog Blog { get; set; } // Hangi bloga ait olduğunu belirtmek için
	}
}