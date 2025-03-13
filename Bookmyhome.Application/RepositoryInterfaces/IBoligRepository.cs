using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.RepositoryInterfaces
{
	public interface IBoligRepository
	{
		List<Bolig> GetAllBolig();
		Bolig GetBolig(int id);
		void AddBolig(Bolig bolig);
		void UpdateBolig(Bolig bolig);
		bool DeleteBolig(int id);
	}
}
