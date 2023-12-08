using ecommerce_app.Data.Base;
using ecommerce_app.Data.ViewModels;
using ecommerce_app.Models;
using System.Threading.Tasks;

namespace ecommerce_app.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
