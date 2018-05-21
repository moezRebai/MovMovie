using Microsoft.EntityFrameworkCore;
using MovMovie.Models;

namespace MovMovie.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
                : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
