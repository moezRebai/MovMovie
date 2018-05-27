using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovMovie.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Data.MovieContext _context;

        public IndexModel(MovMovie.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }

        public async Task OnGetAsync(string movieGenre, string searchInfo)
        {
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            if (!string.IsNullOrEmpty(searchInfo))
            {
                movies = movies.Where(s => s.Title.Contains(searchInfo));
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
