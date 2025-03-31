using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Domain.Models
{
	public class Adresse
	{
		public Adresse() { }

		public int AdresseID { get; set; }
		public int Postnummer { get; set; }
		public string Vejnavn { get; set; }
		public string Husnummer { get; set; }
		public string ?Placering { get; set; }
		public string ?Note {  get; set; }

		public PostnummerOgBy ?PostnummerOgBy { get; set; }

		[Timestamp]
		public byte[] Version { get; set; }

	}
}
