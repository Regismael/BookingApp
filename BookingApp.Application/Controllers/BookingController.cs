using AutoMapper;
using BookingApp.Application.Models;
using BookingApp.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingDomainService _bookingDomainService;
        private readonly IMapper _mapper;

        public BookingController(IBookingDomainService bookingDomainService, IMapper mapper)
        {
            _bookingDomainService = bookingDomainService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<BookingGetModel>), 200)]
        public IActionResult GetAll()
        {
            try
            {
                var bookings = _bookingDomainService.ConsultBookings();

                var model = _mapper.Map<List<BookingGetModel>>(bookings);

                return StatusCode(200, model);
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    e.Message
                });
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BookingGetModel), 200)]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var bookings = _bookingDomainService.GetBookingsById(id);

                if (bookings == null)
                    return NoContent();

                var model = _mapper.Map<BookingGetModel>(bookings);

                return StatusCode(200, model);
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    e.Message
                });
            }
        }
    }
}
