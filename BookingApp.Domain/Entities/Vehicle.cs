using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Domain.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public string? Description { get; set; }

        public List<Booking>? Bookings { get; set; }
    }
}
