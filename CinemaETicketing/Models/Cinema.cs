using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaETicketing.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Image")]
        public string Logo { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        // Relationships
        public ICollection<Movie> Movies { get; set; }
    }
}
