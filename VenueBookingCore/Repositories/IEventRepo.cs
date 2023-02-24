using System.Collections.Generic;
using VenueBookingCore.Models;

namespace VenueBookingCore.Repositories
{
    public interface IEventRepo
    {
        List<Event> GetAllEvents();
        void AddNewEvent(Event e);
        void UpdateEvent(Event e);
        void DeleteEvent(int id);
        Event GetEventById(int id);
    }
}