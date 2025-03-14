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
	internal class BrugerCommand : IBrugerCommand
	{
		private readonly IBrugerRepository _iBrugerRepository;
		private readonly IUnitOfWork _unitOfWork;

		public BrugerCommand(IBrugerRepository brugerRepository, IUnitOfWork unitOfWork) 
		{ 
			_iBrugerRepository = brugerRepository;
			_unitOfWork = unitOfWork;
		}

		public List<Bruger> GetAllBruger()
		{
			return _iBrugerRepository.GetAllBruger();
		}

		public Bruger GetBruger(int id) 
		{ 
			return _iBrugerRepository.GetBruger(id);
		}

		public void AddBruger(Bruger bruger) 
		{
			_iBrugerRepository.AddBruger(bruger);
		}

		public void UpdateBruger(Bruger bruger)
		{
			try
			{
				_unitOfWork.BeginTransaction(System.Data.IsolationLevel.Serializable);

				// Read
				var model = _iBrugerRepository.GetBruger(bruger.BrugerID);

				// DoIt
				model.Update(bruger);

				// Save
				_iBrugerRepository.UpdateBruger(bruger);

				_unitOfWork.Commit();

			}
			catch
			{
				_unitOfWork.Rollback();
				throw;
			}
		}

		public bool DeleteBruger(int id) 
		{ 
			return _iBrugerRepository.DeleteBruger(id);
		}


	}
}
