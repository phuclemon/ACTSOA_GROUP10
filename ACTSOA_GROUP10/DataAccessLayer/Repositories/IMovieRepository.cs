using ACTSOA_GROUP10.CoreLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ACTSOA_GROUP10.DataAccessLayer.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
    }
}
