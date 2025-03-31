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
		public Bruger() { }

		public int BrugerID { get; set; }

		[Required(ErrorMessage = "Fornavn er påkrævet")]
		[StringLength(30, ErrorMessage = "Fornavn må maksimalt være 30 tegn langt.")]
		public string Fornavn { get; set; }

		[Required(ErrorMessage = "Efternavn er påkrævet.")]
		[StringLength(30, ErrorMessage = "Efternavn må maksimalt være 30 tegn langt.")]
		public string Efternavn { get; set; }

		[Required(ErrorMessage = "Telefonnummer er påkrævet")]
		[RegularExpression(@"^\d{8}$", ErrorMessage = "Telefonnummer skal være præcis 8 cifre")]
		public string TelefonNummer { get; set; }

		[Required(ErrorMessage = "Email er påkrævet")]
		[EmailAddress(ErrorMessage = "Ugyldig email-adresse")]
		[RegularExpression(@"^.{2,}@.{2,}\..{2,}$", ErrorMessage = "Email skal have mindst 2 tegn før @ og mindst 2 efter .")]
		public string Email { get; set; }
		public bool Udlejer { get; set; } = false;

		public List<Bolig> ?BoligList { get; set; } = new List<Bolig>();
		public List<Booking> ?BookingList { get; set; } = new List<Booking>();

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
