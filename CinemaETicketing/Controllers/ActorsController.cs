using CinemaETicketing.Data;
using CinemaETicketing.Data.Services.Interfaces;
using CinemaETicketing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _services;

        public ActorsController(IActorsService services)
        {
            _services = services;
        }
        public async Task<ActionResult> Index()
        {
            var data = await _services.GetAllAsync();
            return View(data);
        }

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        // Post: Actors/Create
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid)
                return View(actor);

            await _services.AddAsync(actor);
            await _services.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Details/:id
        public async Task<IActionResult> Details(int id)
        {
            var actor = await _services.GetByIdAsync(id);
            if (actor == null) return View("NotFound");

            return View(actor);
        }

        // Get: Actors/Edit/:id
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _services.GetByIdAsync(id);
            if (actor == null) return View("NotFound");

            return View(actor);
        }

        // Post: Actors/Edit/:id
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FirstName, LastName, ProfilePictureURL, Biography")] Actor newActor)
        {
            // [Bind("Id, FirstName, LastName, ProfilePictureURL, Biography")]
            if (!ModelState.IsValid)
                return View(newActor);

            _services.UpdateAsync(id, newActor);
            await _services.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Delete/:id
        public async Task<IActionResult> Delete(int id)
        {
            var actor = await _services.GetByIdAsync(id);
            if (actor == null) return View("NotFound");

            return View(actor);
        }

        // Post: Actors/Delete/:id
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _services.GetByIdAsync(id);
            if (actor == null) return View("NotFound");

            await _services.DeleteAsync(id);
            await _services.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
