using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.RepositoryInterfaces
{
	public interface IAdresseRepository
	{
		Adresse GetAdresse(int AdresseID);
		void AddAdresse(Adresse adresse);
		bool DeleteAdresse(int AdresseID);
	}
}
