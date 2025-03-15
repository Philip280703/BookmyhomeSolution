using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller.Interfaces
{
	public interface IPostnummerOgByController
	{
		public List<PostnummerOgBy> GetAllPostnummer();

		public PostnummerOgBy GetByPostnummer(int Postnummer);
	}
}
