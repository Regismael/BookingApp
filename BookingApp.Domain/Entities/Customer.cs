using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public List<Booking>? Bookings { get; set; }
    }
}
