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
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<ActionResult> Index()
        {
            var producers = await _service.GetAllAsync();
            return View(producers);
        }

        // GET: Producers/Details/:id
        public async Task<IActionResult> Details(int id)
        {
            var producer = await _service.GetByIdAsync(id);
            if (producer != null)
                return View(producer);

            return View("NotFound");
        }
    }
}
