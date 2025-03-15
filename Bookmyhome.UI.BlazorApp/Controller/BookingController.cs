using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;


namespace Bookmyhome.UI.BlazorApp.Command
{
	public class BookingController
	{
		private readonly IBookingCommand _iBookingServe;

		public BookingController(IBookingCommand bookingCommand) 
		{ 
			_iBookingServe = bookingCommand;
		}

		public List<Booking> GetAllBookings() 
		{ 
			var bookings = _iBookingServe.GetAllBookings();
			return bookings;
		}

		public Booking GetBooking(int id) 
		{ 
			var booking = _iBookingServe.GetBooking(id);
			return booking;
		}

		public void AddBooking(Booking booking)
		{ 
			_iBookingServe.AddBooking(booking);
		}

		public void UpdateBooking(Booking booking)
		{
			_iBookingServe.UpdateBooking(booking);
		}

		public void DeleteBooking(int id) 
		{ 
			_iBookingServe.DeleteBooking(id);
		}

	}
}
