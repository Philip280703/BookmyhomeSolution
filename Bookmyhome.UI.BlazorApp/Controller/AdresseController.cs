using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Command
{
	public class AdresseController
	{
		private readonly IAdresseCommand _command;

		public AdresseController(IAdresseCommand command)
		{
			_command = command;
		}

		public Adresse GetAdresse(int AdresseID)
		{
			return _command.GetAdresse(AdresseID);
		}

		public void AddAdresse(Adresse adresse)
		{
			_command.AddAdresse(adresse);
		}

		public bool DeleteAdresse(int AdresseID)
		{
			return _command.DeleteAdresse(AdresseID);
		}
	}
}
