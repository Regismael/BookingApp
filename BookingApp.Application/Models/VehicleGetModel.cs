using BookingApp.Domain.Entities;

namespace BookingApp.Application.Models
{
    public class VehicleGetModel
    {
        public Guid Id { get; set; }

        public string? Description { get; set; }

    }
}
