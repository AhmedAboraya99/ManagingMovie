using MananagingMovie.Dtos.MovieDtos;
using MananagingMovie.Models;

namespace MananagingMovie.Repositroy.MoiveRepos
{
    public interface IMovieRepo
    {
        List<MovieToGet> GetAll();
        MovieDto GetById(int id);
        void Add(movieadd MovieDto);
    }
}
