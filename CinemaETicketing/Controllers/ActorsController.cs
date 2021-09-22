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
            var data = await _services.GetAllActorsAsync();
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

            await _services.AddActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Details/:id
        public async Task<IActionResult> Details(int id)
        {
            var actor = await _services.GetActorByIdAsync(id);
            if (actor == null) return View("Empty");

            return View(actor);
        }
    }
}
