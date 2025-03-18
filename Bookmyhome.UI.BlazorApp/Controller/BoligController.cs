using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller
{
	public class BoligController
	{
		private readonly IBoligCommand _command;

		public BoligController(IBoligCommand command)
		{
			_command = command;
		}

		public List<Bolig> GetAllBolig()
		{
			return _command.GetAllBolig();
		}

		public Bolig GetBolig(int id)
		{
			return _command.GetBolig(id);
		}

		public void AddBolig(Bolig bolig)
		{
			_command.AddBolig(bolig);
		}

		public void UpdateBolig(Bolig bolig)
		{
			_command.UpdateBolig(bolig);
		}

		public bool DeleteBolig(int id)
		{
			return _command.DeleteBolig(id);
		}
	}
}
