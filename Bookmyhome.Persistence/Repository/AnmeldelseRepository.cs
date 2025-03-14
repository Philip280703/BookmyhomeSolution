using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Domain.Models;
using Bookmyhome.Persistence.ContextDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Persistence.Repository
{
	public class AnmeldelseRepository : IAnmeldelseRepository
	{
		private readonly MyDBContext _db;

		public AnmeldelseRepository(MyDBContext db)
		{
			_db = db;
		}

		public List<Anmeldelse> GetAnmeldelserBasedOnBoligID(int boligID)
		{
			return _db.AnmeldelseEF.ToList();
		}

		public Anmeldelse GetAnmeldelseBasedOnBoligID(int boligID)
		{
			return _db.AnmeldelseEF.Single(a=>a.BoligID==boligID);
		}

		public void AddAnmeldelse(Anmeldelse anmeldelse)
		{
			_db.AnmeldelseEF.Add(anmeldelse);
			_db.SaveChanges();
		}

		public void UpdateAnmeldelse(Anmeldelse anmeldelse)
		{
			var existing = _db.AnmeldelseEF.Single(b => b.AnmeldelseID == anmeldelse.AnmeldelseID);
			if (existing == null)
			{
				return;
			}
			_db.Entry(existing).CurrentValues.SetValues(anmeldelse);
			_db.SaveChanges();
		}

		public bool DeleteAnmeldelse(int anmeldelseID)
		{
			var existing = _db.AnmeldelseEF.Single(b => b.AnmeldelseID == anmeldelseID);
			if (existing == null)
			{
				return false;
			}
			_db.AnmeldelseEF.Remove(existing);
			_db.SaveChanges();
			return true;
		}
	}
}
