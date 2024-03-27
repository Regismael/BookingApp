using BookingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Domain.Interfaces.Services
{
    public interface IVehicleDomainService
    {
        public List<Vehicle>? ConsultVehicles();

        Vehicle? GetVehiclesById(Guid id);
    }
}
