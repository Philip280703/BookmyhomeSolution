using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.Command
{
	public class PostnummerOgByCommand : IPostnummerOgByCommand
	{
		private readonly IPostnummerOgByRepository _repository;

		public PostnummerOgByCommand(IPostnummerOgByRepository repository)
		{
			_repository = repository;
		}

		public List<PostnummerOgBy> GetAll()
		{
			return _repository.GetAll();
		}
		public PostnummerOgBy GetByPostnummer(int postnummer)
		{
			return _repository.GetByPostnummer(postnummer);
		}
	}
}
