using Movie.Web.Data.Base;
using Movie.Web.Data.ViewModels;
using Movie.Web.Models.Domain;

namespace Movie.Web.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movies>
    {
        Task<Movies> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
