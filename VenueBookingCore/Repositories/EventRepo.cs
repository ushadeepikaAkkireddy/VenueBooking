using System.Collections.Generic;
using System.Linq;
using VenueBookingCore.Models;

namespace VenueBookingCore.Repositories
{
    public class EventRepo : IEventRepo
    {
        MyDbContext context;
        public EventRepo(MyDbContext Context)
        {
            context = Context;
        }

        public void AddNewEvent(Event e)
        {
            context.Events.Add(e);
            context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            Event e = context.Events.FirstOrDefault(e=> e.EventId == id);
            if (e != null)
            {
                context.Events.Remove(e);
                context.SaveChanges();
            }
        }

        public List<Event> GetAllEvents()
        {
            return context.Events.ToList();
        }

        public Event GetEventById(int id)
        {
            Event e = context.Events.Find(id);
            return e;
        
    }

        public void UpdateEvent(Event newevent)
        {
           Event e= context.Events.FirstOrDefault(e => e.EventId == newevent.EventId);
            if (e != null)
            {
                
                e.EventName = newevent.EventName;
               e.Details= newevent.Details;
                context.SaveChanges();

            }
        
    }
    }
}
