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
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<ICollection<Cinema>>> Index()
        {
            ICollection<Cinema> cinemas = await _context.Cinemas.ToListAsync();
            return View(cinemas);
        }
    }
}
