using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebCommercial.Models
{
    public class Cinema
    {
        public int CinemaId { get; set; }

        [Display(Name = "Cinema Logo")]
        public string CinemaLogo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
