using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.Command.Interfaces
{
	public interface IBoligCommand
	{
		void AddAccommodation(Bolig bolig);
		void UpdateAccommodation(Bolig bolig);
		void DeleteAccommodation(int id);
	}
}
