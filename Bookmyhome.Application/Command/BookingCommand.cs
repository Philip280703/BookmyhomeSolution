using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Command.Services
{
	public class BookingCommand : IBookingCommand
	{
		private readonly IBookingRepository _iBookingRepository;
		private readonly IUnitOfWork _iUnitOfwork;

		public BookingCommand(IBookingRepository iBookingRepository, IUnitOfWork iUnitOfWork)
		{
			_iBookingRepository = iBookingRepository;
			_iUnitOfwork = iUnitOfWork;
		}

		public List<Booking> GetAllBookings()
		{
			return _iBookingRepository.GetAllBookings();
		}

		public Booking GetBooking(int id)
		{
			return _iBookingRepository.GetBooking(id);
		}

		public List<Booking> GetBookingBasedOnAccommodation(int boligId)
		{
			throw new NotImplementedException();
		}

		public void AddBooking(Booking booking)
		{
			_iBookingRepository.AddBooking(booking);
		}
		public void UpdateBooking(Booking booking)
		{
			try
			{
				_iUnitOfwork.BeginTransaction(System.Data.IsolationLevel.Serializable);

				// Read
				var model = _iBookingRepository.GetBooking(booking.BookingID);

				// DoIt
				model.Update(booking);

				// Save
				_iBookingRepository.UpdateBooking(booking);

				_iUnitOfwork.Commit();

			}
			catch 
			{ 
				_iUnitOfwork.Rollback();
				throw;
			}
			
		}
		public bool DeleteBooking(int id)
		{
			var response = _iBookingRepository.DeleteBooking(id);
			return response;
		}

	}
}
