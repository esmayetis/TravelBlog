﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
	public class iletisim
	{
		[Key]
		public int Id { get; set; }
		public string AdSoyad { get; set; }
		public string Mail { get; set; }
		public string Konu { get; set; }
		public string Mesaj { get; set; }
	}
}