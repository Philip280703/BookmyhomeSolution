using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.Command.Interfaces
{
	public interface IBookingCommand
	{
		List<Booking> GetAllBookings();
		List<Booking> GetBookingBasedOnAccommodation(int boligId);
		Booking GetBooking(int id);
		void AddBooking(Booking booking);
		void UpdateBooking(Booking booking);
		bool DeleteBooking(int id);
	}
}
