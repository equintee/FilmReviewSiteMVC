using System;
using System.Collections.Generic;

#nullable disable

namespace FilmReview.Models
{
    public partial class UserTable
    {
        public UserTable()
        {
            RatingTables = new HashSet<RatingTable>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<RatingTable> RatingTables { get; set; }
    }
}
