using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class ActorsToMovie
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public int Id { get; set; }

        public virtual ActorsTable Actor { get; set; }
        public virtual MovieTable Movie { get; set; }
    }
}
