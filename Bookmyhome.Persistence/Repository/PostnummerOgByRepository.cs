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
	public class PostnummerOgByRepository : IPostnummerOgByRepository
	{
		private readonly MyDBContext _db;
		public List<PostnummerOgBy> GetAll()
		{
			return _db.PostnummerOgByEF.ToList();
		}
		public PostnummerOgBy GetByPostnummer(int postnummer)
		{
			return _db.PostnummerOgByEF.Single(p=>p.Postnummer == postnummer);
		}
	}
}
