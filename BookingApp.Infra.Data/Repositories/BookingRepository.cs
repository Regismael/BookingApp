using BookingApp.Domain.Entities;
using BookingApp.Domain.Interfaces.Repositories;
using BookingApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Infra.Data.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public List<Booking> GetAll()
        {
            using(var context = new DataContext())
            {
                return context.Set<Booking>()
                    .Include(b => b.Vehicle)
                    .Include(b => b.Customer)
                     .ToList();
            }
        }

        public Booking? GetById(Guid id)
        {
            using (var context = new DataContext())
            {
                return context.Set<Booking>()
                    .Include (b => b.Customer)
                    .Include(b => b.Vehicle)
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
            }
        }
    }
}
