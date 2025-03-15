using Bookmyhome.Domain.Models;

namespace Bookmyhome.UI.BlazorApp.Controller.Interfaces
{
	public interface IBookingController
	{
		public List<Booking> GetAllBookings();

		public Booking GetBooking(int id);

		public void AddBooking(Booking booking);

		public void UpdateBooking(Booking booking);

		public void DeleteBooking(int id);
	}
}
