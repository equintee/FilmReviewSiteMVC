using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class ActorsTable
    {
        public ActorsTable()
        {
            ActorsToMovies = new HashSet<ActorsToMovie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<ActorsToMovie> ActorsToMovies { get; set; }
    }
}
