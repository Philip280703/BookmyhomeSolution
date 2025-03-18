using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller
{
	public class BrugerController 
	{
		private readonly IBrugerCommand _command;

        public BrugerController(IBrugerCommand command)
        {
            _command = command;
        }

		public List<Bruger> GetAllBruger()
		{
			return _command.GetAllBruger();
		}

		public Bruger GetBruger(int id)
		{
			return _command.GetBruger(id);
		}

		public void AddBruger(Bruger bruger)
		{
			_command.AddBruger(bruger);
		}

		public void UpdateBruger(Bruger bruger)
		{
			_command.UpdateBruger(bruger);
		}

		public bool DeleteBruger(int id)
		{
			return _command.DeleteBruger(id);
		}
	}
}
