using Microsoft.AspNetCore.Mvc;
using VenueBookingCore.Models;
using VenueBookingCore.Repositories;

namespace VenueBookingCore.Controllers
{
    public class VenueController : Controller
    {
        IVenueRepo repository;
        public VenueController(IVenueRepo repo)
        {
            this.repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.GetAllVenues());
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Venue v)
        {
            repository.AddNewVenue(v);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Venue v = repository.GetVenueById(id);
            if (v != null)
            {
                return View(v);
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Venue v)
        {
            repository.UpdateVenue(v);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Venue v = repository.GetVenueById(id);
            if (v != null)
            {
                return View(v);
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Venue v)
        {
            repository.DeleteVenue(v.VenueId);
            return RedirectToAction("Index");
        }


    }
}
