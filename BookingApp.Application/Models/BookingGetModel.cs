namespace BookingApp.Application.Models
{
    public class BookingGetModel
    {
        public Guid? Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? VehicleId { get; set; }
        public bool? RatingStatus { get; set; }
        public bool? CommentStatus { get; set; }
        public VehicleGetModel? Vehicle { get; set; }
        public CustomerGetModel? Customer { get; set; }



    }
}
