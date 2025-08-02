using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelTripProje.Models.Siniflar
{
	public class Otel
	{
		[Key]
		public int OtelId { get; set; }

		public string Baslik { get; set; }

		public string Aciklama { get; set; }

		public string FotoUrl { get; set; }

		// Blog ile ilişki
		public int BlogId { get; set; }
		public virtual Blog Blog { get; set; }
	}
}
