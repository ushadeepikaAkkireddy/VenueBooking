using System.Collections.Generic;
using VenueBookingCore.Models;

namespace VenueBookingCore.Repositories
{
    public interface IVenueRepo
    {
        List<Venue> GetAllVenues();
        void AddNewVenue(Venue v);
        void UpdateVenue(Venue v);
        void DeleteVenue(int id);
        Venue GetVenueById(int id);
    }
}
