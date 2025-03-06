using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.RepositoryInterfaces
{
	public interface IBookingRepository
	{
		List<Booking> GetAllBookings();
		Booking GetBooking(int id);
		void AddBooking(Booking booking);
		void UpdateBooking(Booking booking);
		bool DeleteBooking(int id);
	}
}
