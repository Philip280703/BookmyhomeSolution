using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Domain.Models
{
	public class Anmeldelse
	{
		public Anmeldelse() { }
		public int AnmeldelseID { get; set; }
		public int GuestID { get; set; }
		public int BoligID { get; set; }
		public double Rating { get; set; }
		public string ?Kommentar {  get; set; }
		public DateTime AnmeldelsesDato { get; set; }

		public Bruger ?bruger { get; set; }
		public Bolig ?bolig { get; set; }

		[Timestamp]
		public byte[] Version { get; set; }


		public void Update(Anmeldelse anmeldelse)
		{
			Rating = anmeldelse.Rating;
			Kommentar = anmeldelse.Kommentar;
			AnmeldelsesDato = anmeldelse.AnmeldelsesDato;
		}
	}
}
