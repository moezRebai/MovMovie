using System;
using System.ComponentModel;

namespace MovMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}
