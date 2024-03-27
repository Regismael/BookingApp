using AutoMapper;
using BookingApp.Application.Models;
using BookingApp.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerDomainService _customerDomainService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerDomainService customerDomainService, IMapper mapper)
        {
            _customerDomainService = customerDomainService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CustomerGetModel>), 200)]
        public IActionResult GetAll()
        {
            try
            {
                var customers = _customerDomainService.ConsultCustomers();

                var model = _mapper.Map<CustomerGetModel>(customers);

                return StatusCode(200, model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CustomerGetModel), 200)]
        public IActionResult GetById(Guid id) 
        {
            try
            {
                var customers = _customerDomainService.GetCustomerById(id);

                if (customers == null)
                    return NoContent();

                var model = _mapper.Map<CustomerGetModel>(customers);

                return StatusCode(200, model);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
