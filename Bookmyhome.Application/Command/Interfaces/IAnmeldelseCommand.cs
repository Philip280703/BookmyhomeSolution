using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.Command.Interfaces
{
	public interface IAnmeldelseCommand
	{
		List<Anmeldelse> GetAnmeldelserBasedOnBoligID(int boligID);
		Anmeldelse GetAnmeldelseBasedOnBoligID(int boligID);
		void AddAnmeldelse(Anmeldelse anmeldelse);
		void UpdateAnmeldelse(Anmeldelse anmeldelse, int boligID);
		bool DeleteAnmeldelse(int anmeldelseID);
	}
}
