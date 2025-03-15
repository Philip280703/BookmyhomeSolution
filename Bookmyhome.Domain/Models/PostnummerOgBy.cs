using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Domain.Models
{
	public class PostnummerOgBy
	{
		[Key]
		public int Postnummer { get; set; }
		public string Bynavn { get; set; }


		[Timestamp]
		public byte[] Version { get; set; }
	}
}
