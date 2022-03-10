using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class DirectorsToMovie
    {
        public int DirectorId { get; set; }
        public int MovieId { get; set; }
        public int Id { get; set; }

        public virtual DirectorTable Director { get; set; }
        public virtual MovieTable Movie { get; set; }
    }
}
