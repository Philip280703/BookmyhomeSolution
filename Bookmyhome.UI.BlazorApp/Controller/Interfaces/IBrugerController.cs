using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller.Interfaces
{
	public interface IBrugerController
	{
		public List<Bruger> GetAllBruger();

		public Bruger GetBruger(int id);


		public void AddBruger(Bruger bruger);

		public void UpdateBruger(Bruger bruger);

		public bool DeleteBruger(int id);
	}
}
