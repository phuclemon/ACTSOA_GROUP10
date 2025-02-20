using ACTSOA_GROUP10.CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using MovieSeries.DataAccessLayer;


namespace ACTSOA_GROUP10.DataAccessLayer
{
    public class MovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task AddMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount)
        {
            return await _context.Movies
            .FromSqlRaw("EXEC GetTopRatedMovies @top_count = {0}", topCount)
            .ToListAsync();
        }
    }
}