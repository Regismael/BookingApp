using BookingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Domain.Interfaces.Repositories
{
    public interface IBookingRepository
    {
        List<Booking> GetAll();

        Booking GetById(Guid id);
    }
}
