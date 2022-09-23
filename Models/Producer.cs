using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebCommercial.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }

        public string Biography { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
