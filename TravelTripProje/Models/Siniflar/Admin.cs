﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
	public class Admin
	{
		[Key]
		public int Id { get; set; }
		public string KullaniciAdi { get; set; }
		public string Sifre { get; set; }
		
	}
}