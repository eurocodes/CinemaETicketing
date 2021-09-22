using CinemaETicketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Data.Services.Interfaces
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<Actor> GetActorByIdAsync(int id);
        Task AddActorAsync(Actor actor);
        Task<Actor> UpdateActorAsync(int id, Actor newData);
        Task DeleteAsync(int id);
    }
}
