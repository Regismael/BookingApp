using AutoMapper;
using BookingApp.Application.Models;
using BookingApp.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleDomainService _vehicleDomainService;
        private readonly IMapper _mapper;

        public VehicleController(IVehicleDomainService vehicleDomainService, IMapper mapper)
        {
            _vehicleDomainService = vehicleDomainService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<VehicleGetModel>), 200)]
        public IActionResult GetAll()
        {
            try
            {
                var vehicles = _vehicleDomainService.ConsultVehicles();

                var model = _mapper.Map<VehicleGetModel>(vehicles);

                return StatusCode(200, model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(VehicleGetModel), 200)]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var vehicles = _vehicleDomainService.GetVehiclesById(id);

                if (vehicles == null)
                    return NoContent();

                var model = _mapper.Map<VehicleGetModel>(vehicles);

                return StatusCode(200, model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
