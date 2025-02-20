using ACTSOA_GROUP10.CoreLayer.Entities;
using ACTSOA_GROUP10.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACTSOA_GROUP10.ServiceLayer.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetMovieByIdAsync(id);
        }

        public async Task AddMovieAsync(Movie movie)
        {
            var existingMovies = await _movieRepository.GetAllMoviesAsync();
            if (existingMovies.Any(m => m.Title == movie.Title))
            {
                throw new ArgumentException("A movie with the same title already exists.");
            }
            await _movieRepository.AddMovieAsync(movie);
        }

        public async Task<Movie?> UpdateMovieAsync(Movie movie)
        {
            var existingMovie = await _movieRepository.GetMovieByIdAsync(movie.Id);
            if (existingMovie == null)
            {
                return null;
            }
            await _movieRepository.UpdateMovieAsync(movie);
            return movie;
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var existingMovie = await _movieRepository.GetMovieByIdAsync(id);
            if (existingMovie == null)
            {
                return false;
            }
            await _movieRepository.DeleteMovieAsync(id);
            return true;
        }

        public Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount)
        {
            throw new NotImplementedException();
        }
    }
}
