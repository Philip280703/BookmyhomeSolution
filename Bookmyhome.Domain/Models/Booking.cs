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
		public int BookingID { get; set; }
		public int GuestID { get; set; }
		public int BoligID { get; set; }
		public DateTime StartDato { get; set; }
		public DateTime SlutDato { get; set ; }
		public double ?TotalPris { get; set; }
		public string Status { get; set; }

		public Bruger ?bruger { get; set; }
		public Bolig ?bolig { get; set; }

		[Timestamp]
		public byte[] Version { get; set; }


		public void Update(Booking booking)
		{
			GuestID = booking.GuestID;
			BoligID = booking.BoligID;
			StartDato = booking.StartDato;
			SlutDato = booking.SlutDato;
			TotalPris = booking.TotalPris ?? 0;
		}
	}
}
