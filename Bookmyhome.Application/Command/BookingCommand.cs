using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Application.Services.Interfaces;
using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Application.Services
{
	internal class BookingCommand : IBookingCommand
	{
		private readonly IBookingRepository _iBookingRepository;

		public BookingCommand(IBookingRepository iBookingRepository)
		{
			_iBookingRepository = iBookingRepository;
		}

		public List<Booking> GetAllBookings()
		{
			return _iBookingRepository.GetAllBookings();
		}

		public Booking GetBooking(int id)
		{
			return _iBookingRepository.GetBooking(id);
		}

		public void AddBooking(Booking booking)
		{
			_iBookingRepository.AddBooking(booking);
		}
		public void UpdateBooking(Booking booking)
		{
			_iBookingRepository.UpdateBooking(booking);
		}
		public bool DeleteBooking(int id)
		{
			var response = _iBookingRepository.DeleteBooking(id);
			return response;
		}

	}
}
