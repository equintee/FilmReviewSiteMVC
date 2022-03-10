using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class RatingTable
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public int Id { get; set; }

        public virtual MovieTable Movie { get; set; }
        public virtual UserTable User { get; set; }
    }
}
