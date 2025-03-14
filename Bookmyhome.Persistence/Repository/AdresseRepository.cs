using Bookmyhome.Domain.Models;
using Bookmyhome.Application.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmyhome.Persistence.ContextDB;

namespace Bookmyhome.Persistence.Repository
{
	public class AdresseRepository : IAdresseRepository
	{
		private readonly MyDBContext _db;

		public AdresseRepository(MyDBContext db)
		{
			_db = db;
		}

		public Adresse GetAdresse(int AdresseID)
		{
			return _db.AdresseEF.Single(a=>a.AdresseID==AdresseID);
		}

		public void AddAdresse(Adresse adresse)
		{
			_db.AdresseEF.Add(adresse);
			_db.SaveChanges();
		}

		public bool DeleteAdresse(int AdresseID)
		{
			var existing = _db.AdresseEF.Single(a => a.AdresseID == AdresseID);
			if (existing == null)
			{
				return false;
			}
			_db.AdresseEF.Remove(existing);
			_db.SaveChanges();
			return true;
		}
	}
}
