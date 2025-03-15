using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;
using Bookmyhome.UI.BlazorApp.Controller.Interfaces;

namespace Bookmyhome.UI.BlazorApp.Controller
{
	public class PostnummerOgByController : IPostnummerOgByController
	{
		private readonly IPostnummerOgByCommand _command;

		public PostnummerOgByController(IPostnummerOgByCommand command)
		{
			_command = command;
		}

		public List<PostnummerOgBy> GetAllPostnummer()
		{
			return _command.GetAll();
		}

		public PostnummerOgBy GetByPostnummer(int Postnummer) 
		{ 
			return _command.GetByPostnummer(Postnummer);
		}
	}
}
