using CinemaETicketing.Data;
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
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<ICollection<Producer>>> Index()
        {
            ICollection<Producer> producers = await _context.Producers.ToListAsync();
            return View(producers);
        }
    }
}
