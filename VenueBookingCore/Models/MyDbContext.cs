using Microsoft.EntityFrameworkCore;

namespace VenueBookingCore.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
           
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
    }
}
