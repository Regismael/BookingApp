using BookingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Domain.Interfaces.Services
{
    public interface IBookingDomainService
    {
        public List<Booking>? ConsultBookings();

        Booking? GetBookingsById(Guid id);
    }
}
