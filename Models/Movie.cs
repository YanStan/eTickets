using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebCommercial.Data.Enums;

namespace WebCommercial.Models
{
    public class Movie
    {
        public int MovieId { get; set; }


        [Display(Name = "Movie Name")]
        public string Name { get; set; }


        [Display(Name = "Movie Description")]
        public string Description { get; set; }

        [Display(Name = "Movie Image")]
        public string ImageURL { get; set; }


        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}
