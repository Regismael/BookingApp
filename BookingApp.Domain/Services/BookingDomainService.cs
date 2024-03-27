using BookingApp.Domain.Entities;
using BookingApp.Domain.Interfaces.Repositories;
using BookingApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Domain.Services
{
    public class BookingDomainService : IBookingDomainService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingDomainService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public List<Booking>? ConsultBookings()
        {
            return _bookingRepository.GetAll();
        }

        public Booking? GetBookingsById(Guid id)
        {
            return _bookingRepository.GetById(id);
        }
    }
}
