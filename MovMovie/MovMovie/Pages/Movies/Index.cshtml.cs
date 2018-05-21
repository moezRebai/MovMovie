using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovMovie.Models;

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

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
