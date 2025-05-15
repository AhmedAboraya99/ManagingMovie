using MananagingMovie.Data;
using MananagingMovie.Dtos.CatgegoryDtos;
using MananagingMovie.Models;

namespace MananagingMovie.Repositroy.CategoryRepos
{
    public interface ICategoryRepo
    {
        public bool Add(CategoryToAdd category);

        public bool Update(int id, CategoryToAdd category);
    }
}
