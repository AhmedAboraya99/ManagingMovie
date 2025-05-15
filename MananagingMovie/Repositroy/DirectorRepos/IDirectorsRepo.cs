using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Models;

namespace MananagingMovie.Repositroy.DirectorRepos
{
    public interface IDirectorsRepo
    {
        bool Add(DirectorsToAdd directordDto);
        bool Update(int id, DirectorToUpdate directordDto);
        bool Delete(int id, int movieId);
    }
}
