using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class DirectorTable
    {
        public DirectorTable()
        {
            DirectorsToMovies = new HashSet<DirectorsToMovie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<DirectorsToMovie> DirectorsToMovies { get; set; }
    }
}
