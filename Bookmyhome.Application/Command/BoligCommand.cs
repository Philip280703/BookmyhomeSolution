using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Domain.Models;

namespace Bookmyhome.Application.Command
{
	internal class BoligCommand : IBoligCommand
	{
        private readonly IBoligRepository _repository;
		private readonly IUnitOfWork _iUnitOfwork;

        public BoligCommand(IBoligRepository repository, IUnitOfWork iUnitOfWork)
        {
            _repository = repository;
            _iUnitOfwork = iUnitOfWork;
        }

        public List<Bolig> GetAllBolig()
        {
            return _repository.GetAllBolig();
        }

        public Bolig GetBolig(int id) 
        {
            return _repository.GetBolig(id);
        }

        public void AddBolig(Bolig bolig) 
        {
            _repository.AddBolig(bolig);
        }

		public void UpdateBolig(Bolig bolig)
		{
			try
			{
				_iUnitOfwork.BeginTransaction(System.Data.IsolationLevel.Serializable);

				// Read
				var model = _repository.GetBolig(bolig.BoligID);

				// DoIt
				model.Update(bolig);

				// Save
				_repository.UpdateBolig(bolig);

				_iUnitOfwork.Commit();

			}
			catch
			{
				_iUnitOfwork.Rollback();
				throw;
			}

		}

		public bool DeleteBolig(int id) 
        {
            return _repository.DeleteBolig(id);
        }
        
    }
}
