using ACTSOA_GROUP10.CoreLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTSOA_GROUP10.ServiceLayer.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
        Task<IEnumerable<Movie>> GetTopRatedMoviesWithSpAsync(int topCount);
        Task<Movie?> UpdateMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(int id);
    }
}
