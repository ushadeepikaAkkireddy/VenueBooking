using System.ComponentModel.DataAnnotations;

namespace VenueBookingCore.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }
        public string EventName { get; set; }
        public string VenueName { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
    }
}
