using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Domain.Models
{
	public class Bolig
	{
		public Bolig() { }

		public int BoligID { get; set; }
		public string Title { get; set; }
		public string ?Beskrivelse { get; set; } = string.Empty;
		public int ?AdresseID { get; set; }
		public double PrisPrNat { get; set; }
		public int ?HostBrugerID { get; set; }

		public List<Booking> BookingList { get; set; } = new List<Booking>();
		public List<Anmeldelse> AnmeldelseList { get; set; } = new List<Anmeldelse>();

		public Adresse ?Adresse { get; set; }
		public Bruger ?bruger {  get; set; }


		[Timestamp]
		public byte[] Version { get; set; }

		public void Update(Bolig bolig)
		{
			Title = bolig.Title;
			Beskrivelse = bolig.Beskrivelse;
			PrisPrNat = bolig.PrisPrNat;
		}
	}
}
