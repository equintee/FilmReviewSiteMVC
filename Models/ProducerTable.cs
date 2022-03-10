using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class ProducerTable
    {
        public ProducerTable()
        {
            ProducersToMovies = new HashSet<ProducersToMovie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<ProducersToMovie> ProducersToMovies { get; set; }
    }
}
