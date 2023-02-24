using System.ComponentModel.DataAnnotations;

namespace VenueBookingCore.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Details { get; set; }
       
    }
}
