using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.Command.Interfaces
{
	public interface IPostnummerOgByCommand
	{
		List<PostnummerOgBy> GetAll();
		PostnummerOgBy GetByPostnummer(int postnummer);
	}
}
