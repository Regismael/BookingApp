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
    public class VehicleDomainService : IVehicleDomainService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleDomainService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle>? ConsultVehicles()
        {
            return _vehicleRepository.GetAll();
        }

        public Vehicle? GetVehiclesById(Guid id)
        {
            return _vehicleRepository.GetById(id);
        }
    }
}
