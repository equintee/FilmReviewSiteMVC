using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class ProducersToMovie
    {
        public int ProducerId { get; set; }
        public int MovieId { get; set; }
        public int Id { get; set; }

        public virtual MovieTable Movie { get; set; }
        public virtual ProducerTable Producer { get; set; }
    }
}
