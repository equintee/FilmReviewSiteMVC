using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class MovieTable
    {
        public MovieTable()
        {
            ActorsToMovies = new HashSet<ActorsToMovie>();
            DirectorsToMovies = new HashSet<DirectorsToMovie>();
            ProducersToMovies = new HashSet<ProducersToMovie>();
            RatingTables = new HashSet<RatingTable>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double AverageRating { get; set; }
        public string Language { get; set; }
        public DateTime RelaseDate { get; set; }
        public string Subject { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ActorsToMovie> ActorsToMovies { get; set; }
        public virtual ICollection<DirectorsToMovie> DirectorsToMovies { get; set; }
        public virtual ICollection<ProducersToMovie> ProducersToMovies { get; set; }
        public virtual ICollection<RatingTable> RatingTables { get; set; }
    }
}
