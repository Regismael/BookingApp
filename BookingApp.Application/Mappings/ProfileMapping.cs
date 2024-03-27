using AutoMapper;
using BookingApp.Application.Models;
using BookingApp.Domain.Entities;

namespace BookingApp.Application.Mappings
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<Customer, CustomerGetModel>();

            CreateMap<Vehicle, VehicleGetModel>();

            CreateMap<Booking, BookingGetModel>();
        }

    }
}
