using Bookmyhome.Persistence.ContextDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmyhome.Domain.Models;
using Bookmyhome.Application.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Bookmyhome.Persistence.Repository
{
	public class BrugerRepository : IBrugerRepository
	{
		private readonly MyDBContext _db;
		public BrugerRepository(MyDBContext dBContext) 
		{ 
			_db = dBContext;
		}

		public List<Bruger> GetAllBruger()
		{
			return _db.BrugerEF.Include(b=>b.BoligList).ToList();
		}

		public Bruger GetBruger(int id)
		{
			return _db.BrugerEF.Single(b=>b.BrugerID == id);
		}

		public void AddBruger(Bruger bruger) 
		{ 
			_db.BrugerEF.Add(bruger);
			_db.SaveChanges();
		}

		public void UpdateBruger(Bruger bruger)
		{
			var existingBruger = _db.BrugerEF.Single(b => b.BrugerID == bruger.BrugerID);
			if (existingBruger == null)
			{
				return;
			}
			_db.Entry(existingBruger).CurrentValues.SetValues(bruger);
			_db.SaveChanges();
		}

		public bool DeleteBruger(int id) 
		{
			var existingBruger = _db.BrugerEF.Single(b => b.BrugerID == id);
			if (existingBruger == null)
			{
				return false;
			}
			_db.Remove(existingBruger);
			_db.SaveChanges();
			return true;
		}



	}
}
