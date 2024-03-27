using BookingApp.Domain.Entities;
using BookingApp.Domain.Interfaces.Repositories;
using BookingApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Infra.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> GetAll()
        {
            using (var context = new DataContext())
            {
                return context.Set<Vehicle>()
                    .OrderBy(v => v.Description)
                    .ToList();
            }
        }

        public Vehicle? GetById(Guid id)
        {
            using(var context = new DataContext())
            {
                return context.Set<Vehicle>()
                    .Where(v => v.Id == id)
                    .FirstOrDefault();
            }
        }
    }
}
