using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovMovie.Models;
using System;
using System.Linq;

namespace MovMovie.Data
{
    /// <summary>
    /// Seed default data to database
    /// </summary>
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = 7.5
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = 8
                    },

                    new Movie
                    {
                        Title = "Avengers Infinity War",
                        ReleaseDate = DateTime.Parse("2018-2-23"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = 9
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = 7.6
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
