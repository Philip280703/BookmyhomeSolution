using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller.Interfaces
{
	public interface IAnmeldelseController
	{
		public List<Anmeldelse> GetAnmeldelserBasedOnBoligID(int boligID);
		public Anmeldelse GetAnmeldelseBasedOnBoligID(int boligID);

		public void AddAnmeldelse(Anmeldelse anmeldelse);
		public void UpdateAnmeldelse(Anmeldelse anmeldelse, int boligID);
		public bool DeleteAnmeldelse(int anmeldelseID);
	}
}
