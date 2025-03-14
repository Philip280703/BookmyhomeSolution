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

		public int BrugerID { get; private set; }
		public string Fornavn { get; private set; } 
		public string Efternavn { get; private set; }
		public string TelefonNummer { get; private set; }
		public string Email { get; private set; }
		public bool Udlejer { get; private set; }

		public List<Bolig> BoligList { get; private set; } = new List<Bolig>();
		public List<Booking> BookingList { get; private set; } = new List<Booking>();

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
