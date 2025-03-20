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
	public class AdresseCommand : IAdresseCommand
	{
		private readonly IAdresseRepository _repository;

		public AdresseCommand(IAdresseRepository repository)
		{
			_repository = repository;
		}

		public Adresse GetAdresse(int AdresseID)
		{
			return _repository.GetAdresse(AdresseID);
		}

		public void AddAdresse(Adresse adresse) 
		{ 
			_repository.AddAdresse(adresse);
		}

		public bool DeleteAdresse(int AdresseID) 
		{
			return _repository.DeleteAdresse(AdresseID);
		}
	}
}
