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
	internal class AnmeldelseCommand : IAnmeldelseCommand
	{
		private readonly IAnmeldelseRepository _anmeldelseRepository;
		private readonly IUnitOfWork _unitOfWork;

		public AnmeldelseCommand(IAnmeldelseRepository repository, IUnitOfWork unitOfWork)
		{
			_anmeldelseRepository = repository;
			_unitOfWork = unitOfWork;
		}

		public List<Anmeldelse> GetAnmeldelserBasedOnBoligID(int boligID)
		{
			return _anmeldelseRepository.GetAnmeldelserBasedOnBoligID(boligID);
		}

		public Anmeldelse GetAnmeldelseBasedOnBoligID(int boligID)
		{
			return _anmeldelseRepository.GetAnmeldelseBasedOnBoligID(boligID);
		}

		public void AddAnmeldelse(Anmeldelse anmeldelse)
		{
			_anmeldelseRepository.AddAnmeldelse(anmeldelse);
		}

		public void UpdateAnmeldelse(Anmeldelse anmeldelse, int boligID)
		{
			try
			{
				_unitOfWork.BeginTransaction(System.Data.IsolationLevel.Serializable);

				// Read
				var model = _anmeldelseRepository.GetAnmeldelseBasedOnBoligID(boligID);

				// DoIt
				model.Update(anmeldelse);

				// Save
				_anmeldelseRepository.UpdateAnmeldelse(anmeldelse);

				_unitOfWork.Commit();

			}
			catch
			{
				_unitOfWork.Rollback();
				throw;
			}
		}
		public bool DeleteAnmeldelse(int anmeldelseID)
		{
			return _anmeldelseRepository.DeleteAnmeldelse(anmeldelseID);
		}
	}
}
