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
		public int AnmeldelseID { get; private set; }
		public int GuestID { get; private set; }
		public int BoligID { get; private set; }
		public double Rating { get; private set; }
		public string Kommentar {  get; private set; }
		public DateTime AnmeldelsesDato { get; private set; }

		public Bruger ?bruger { get; private set; }
		public Bolig ?bolig { get; private set; }

		[Timestamp]
		public byte[] Version { get; set; }
	}
}
