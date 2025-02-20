using ACTSOA_GROUP10.CoreLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTSOA_GROUP10.DataAccessLayer
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
        Task DeleteMovieAsync(int id);
        Task<Movie?> UpdateMovieAsync(Movie movie); // Thêm phương thức này
    }
}
