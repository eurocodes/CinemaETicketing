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
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<ICollection<Movie>>> Index()
        {
            ICollection<Movie> movies = await _context.Movies.Include(c => c.Cinemas).OrderBy(n => n.Name).ToListAsync();
            return View(movies);
        }
    }
}
