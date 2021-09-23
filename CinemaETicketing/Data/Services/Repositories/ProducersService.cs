using CinemaETicketing.Data.Base;
using CinemaETicketing.Data.Services.Interfaces;
using CinemaETicketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Data.Services.Repositories
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
