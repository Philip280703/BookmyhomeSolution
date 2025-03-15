using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller
{
	public class AnmeldelseController
	{
		private readonly IAnmeldelseCommand _command;

		public AnmeldelseController(IAnmeldelseCommand command)
		{
			_command = command;
		}

		public List<Anmeldelse> GetAnmeldelserBasedOnBoligID(int boligID)
		{
			return _command.GetAnmeldelserBasedOnBoligID(boligID);
		}

		public Anmeldelse GetAnmeldelseBasedOnBoligID(int boligID)
		{
			return _command.GetAnmeldelseBasedOnBoligID(boligID);
		}

		public void AddAnmeldelse(Anmeldelse anmeldelse)
		{
			_command.AddAnmeldelse(anmeldelse);
		}

		public void UpdateAnmeldelse(Anmeldelse anmeldelse, int boligID)
		{
			_command.UpdateAnmeldelse(anmeldelse, boligID);
		}
		public bool DeleteAnmeldelse(int anmeldelseID)
		{
			return _command.DeleteAnmeldelse(anmeldelseID);
		}
	}
}
