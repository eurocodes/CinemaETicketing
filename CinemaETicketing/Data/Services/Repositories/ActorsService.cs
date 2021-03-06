using CinemaETicketing.Data.Base;
using CinemaETicketing.Data.Services.Interfaces;
using CinemaETicketing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Data.Services.Repositories
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}
