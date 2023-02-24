using System.Collections.Generic;
using System.Linq;
using VenueBookingCore.Models;

namespace VenueBookingCore.Repositories
{
    public class VenueRepo : IVenueRepo
    {
        MyDbContext context;
        public VenueRepo(MyDbContext Context)
        {
            context = Context;
        }
        public void AddNewVenue(Venue v)
        {
            context.Venues.Add(v);
            context.SaveChanges();
        }

        public void DeleteVenue(int id)
        {
           Venue v = context.Venues.FirstOrDefault(v => v.VenueId == id);
            if (v!= null)
            {
                context.Venues.Remove(v);
                context.SaveChanges();
            }
        }

        public List<Venue> GetAllVenues()
        {
            return context.Venues.ToList();
        }

       
        public void UpdateVenue(Venue newvenue)
        {
            Venue v = context.Venues.FirstOrDefault(v => v.VenueId == newvenue.VenueId);
            if (v != null)
            {
                v.VenueId = newvenue.VenueId;
                v.EventName = newvenue.EventName;
                v.VenueName = newvenue.VenueName;
                v.Price = newvenue.Price;
                v.Address = newvenue.Address;
                context.SaveChanges();

            }
        }

      public    Venue GetVenueById(int id)
        {
            Venue v = context.Venues.Find(id);
            return v;
        }
    }
}
