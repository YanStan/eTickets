using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebCommercial.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }

        public string Biography { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
