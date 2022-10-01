using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebCommercial.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string Biography { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
