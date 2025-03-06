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

		public int AdresseID { get; private set; }
		public int Postnummer { get; private set; }
		public string Vejnavn { get; private set; }
		public string Husnummer { get; private set; }
		public string Placering { get; private set; }
		public string Note {  get; private set; }

		public PostnummerOgBy ?PostnummerOgBy { get; private set; }

		[Timestamp]
		public byte[] Version { get; set; }

	}
}
