using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller.Interfaces
{
    public interface IAdresseController
    {
		public Adresse GetAdresse(int AdresseID);
		public void AddAdresse(Adresse adresse);
		public bool DeleteAdresse(int AdresseID);

	}

}
