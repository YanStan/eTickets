using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebCommercial.Data;

namespace WebCommercial.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allmovies = await _context.Movies
                .Include(x => x.Cinema)
                .Include(x => x.Producer)
                .Include(x => x.Actors_Movies)
                .OrderBy(x => x.Name)
                .ToListAsync();
            return View(allmovies);
        }
    }
}
