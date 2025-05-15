using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Models;

namespace MananagingMovie.Repositroy.NationalityRepos
{
    public interface INationalityRepo
    {
        bool Add(NationalityToAdd nationality);
        bool Delete(int id);
        bool Deletedirector(int id);
    }
}
