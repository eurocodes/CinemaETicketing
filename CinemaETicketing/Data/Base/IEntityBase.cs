using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Data.Base
{
    public interface IEntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
