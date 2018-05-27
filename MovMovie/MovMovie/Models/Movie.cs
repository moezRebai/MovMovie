using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1966", "1/1/2020")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Range(0.0, 10)]
        public double Rating { get; set; }
    }
}
