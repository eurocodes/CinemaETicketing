using CinemaETicketing.Data.Services.Interfaces;
using CinemaETicketing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Data.Services.Repositories
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddActorAsync(Actor actor)
        {
            if (actor != null)
            {
                await _context.AddAsync(actor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            if (actor != null)
                return actor;

            return null;
        }

        public async Task<IEnumerable<Actor>> GetAllActorsAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> UpdateActorAsync(int id, Actor newData)
        {
            throw new NotImplementedException();
        }
    }
}
