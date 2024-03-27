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
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAll()
        {
            using (var context = new DataContext())
            {
                return context.Set<Customer>()
                    .OrderBy(c => c.Name)
                    .ToList();
            }
        }

        public Customer? GetById(Guid id)
        {
            using(var context = new DataContext())
            {
                return context.Set<Customer>()
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }
    }
}
