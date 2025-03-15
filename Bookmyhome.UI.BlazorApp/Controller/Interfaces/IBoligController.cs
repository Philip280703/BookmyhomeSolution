using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller.Interfaces
{
	public interface IBoligController
	{
		public List<Bolig> GetAllBolig();
		public Bolig GetBolig(int id);
		public void AddBolig(Bolig bolig);
		public void UpdateBolig(Bolig bolig);

		public bool DeleteBolig(int id);
	}
}
