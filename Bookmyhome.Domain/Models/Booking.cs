using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Domain.Models
{
	public class Booking
	{
		public Booking() { }
		public int BookingID { get; private set; }
		public int GuestID { get; private set; }
		public int BoligID { get; private set; }
		public DateTime StartDato { get; private set; }
		public DateTime SlutDato { get; private set ; }
		public double ?TotalPris { get; private set; }
		public string Status { get; private set; }

		public Bruger ?bruger { get; private set; }
		public Bolig ?bolig { get; private set; }

		[Timestamp]
		public byte[] Version { get; set; }
	}
}
