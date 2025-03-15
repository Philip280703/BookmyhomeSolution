using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Domain.Models
{
	public class Bruger
	{
		Bruger() { }

		public int BrugerID { get; set; }
		public string Fornavn { get; set; } 
		public string Efternavn { get; set; }
		public string TelefonNummer { get; set; }
		public string Email { get; set; }
		public bool Udlejer { get; set; }

		public List<Bolig> BoligList { get; set; } = new List<Bolig>();
		public List<Booking> BookingList { get; set; } = new List<Booking>();

		[Timestamp]
		public byte[] Version { get; set; }


		public void Update(Bruger bruger)
		{
			Fornavn = bruger.Fornavn;
			Efternavn = bruger.Efternavn;
			TelefonNummer = bruger.TelefonNummer;
			Email = bruger.Email;
			Udlejer = bruger.Udlejer;
		}

	}
}
