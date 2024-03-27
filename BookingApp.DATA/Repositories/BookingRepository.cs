using BookingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.DATA.Repositories
{
  
    public class BookingRepository
    {
        private readonly List<Booking> _bookings;

        public BookingRepository()
        {

            _bookings = new List<Booking>
        {
            new Booking
            {
                BookingId = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7),
                CustomerId = 1,
                VehicleId = 2,
                RatingStatus = true,
                CommentStatus = false,
                Customer = new Customer { CustomerId = 1, CustomerName = "John Doe" },
                Vehicle = new Vehicle { VehicleId = 2, VehicleModel = "Car Model" }
            },
            // Adicione mais bookings conforme necessário
        };
        }

    }
}
