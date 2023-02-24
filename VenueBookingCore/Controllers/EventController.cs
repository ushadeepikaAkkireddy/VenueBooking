using Microsoft.AspNetCore.Mvc;
using VenueBookingCore.Models;
using VenueBookingCore.Repositories;

namespace VenueBookingCore.Controllers
{
    public class EventController : Controller
    {
        IEventRepo repository;
        public EventController(IEventRepo repo)
        {
            this.repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.GetAllEvents());
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Event e)
        {
            repository.AddNewEvent(e);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Event e = repository.GetEventById(id);
            if (e != null)
            {
                return View(e);
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Event e)
        {
            repository.UpdateEvent(e);
            return RedirectToAction("Index");
        }
            public IActionResult Delete(int id)
            { 
                Event e = repository.GetEventById(id); 
                if (e != null)
                {
                    return View(e);
                }
                else return NotFound();
            }
            [HttpPost]
            public IActionResult Delete(Event e)
            {
                repository.DeleteEvent(e.EventId);
                return RedirectToAction("Index");
            }
        }
    
}
