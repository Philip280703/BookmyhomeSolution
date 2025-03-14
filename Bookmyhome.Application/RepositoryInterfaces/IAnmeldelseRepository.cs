﻿using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.RepositoryInterfaces
{
	public interface IAnmeldelseRepository
	{
		List<Anmeldelse> GetAnmeldelserBasedOnBoligID(int boligID);
		Anmeldelse GetAnmeldelseBasedOnBoligID(int boligID);
		void AddAnmeldelse(Anmeldelse anmeldelse);
		void UpdateAnmeldelse(Anmeldelse anmeldelse);
		bool DeleteAnmeldelse(int anmeldelseID);
		
	}
}
