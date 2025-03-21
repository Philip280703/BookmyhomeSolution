﻿using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.RepositoryInterfaces
{
	public interface IBrugerRepository
	{
		List<Bruger> GetAllBruger();
		Bruger GetBruger(int id);	
		void AddBruger(Bruger bruger);
		void UpdateBruger(Bruger bruger);
		bool DeleteBruger(int id);
	}
}
