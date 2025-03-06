using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Domain.Models;
using Bookmyhome.Persistence.ContextDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Persistence.Repository
{
	public class BookingRepository : IBookingRepository
	{
		private readonly MyDBContext _db;

		public BookingRepository(MyDBContext dbContext)
		{
			_db = dbContext;
		}

		public List<Booking> GetAllBookings()
		{
			return _db.BookingEF.ToList();
		}

		public Booking GetBooking(int id)
		{
			return _db.BookingEF.Single(b=>b.BookingID == id);
		}

		public void AddBooking(Booking booking)
		{
			_db.BookingEF.Add(booking);
			_db.SaveChanges();
		}

		public void UpdateBooking(Booking booking)
		{
			var existingBooking = _db.BookingEF.Find(booking.BookingID);
			if (existingBooking != null)
			{
				_db.Entry(existingBooking).CurrentValues.SetValues(booking);
				_db.SaveChanges();
			}
		}

		public bool DeleteBooking(int id)
		{
			var booking = _db.BookingEF.Find(id);
			if (booking == null)
			{
				return false;
			}
			_db.BookingEF.Remove(booking);
			_db.SaveChanges();
			return true;
		}
	}
}
