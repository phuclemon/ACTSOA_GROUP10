using Microsoft.EntityFrameworkCore;
using ACTSOA_GROUP10.CoreLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ACTSOA_GROUP10.DataAccessLayer.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        public MovieRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync() =>
            await _context.Movies.ToListAsync();

        public async Task<Movie> GetMovieByIdAsync(int id) =>
            await _context.Movies.FindAsync(id);

        public async Task AddMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }
    }
}
