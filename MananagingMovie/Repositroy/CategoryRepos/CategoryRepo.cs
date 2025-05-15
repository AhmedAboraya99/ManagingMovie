using MananagingMovie.Data;
using MananagingMovie.Dtos.CatgegoryDtos;
using MananagingMovie.Models;
using MananagingMovie.Repositroy.CategoryRepos;

namespace MananagingMovie.Repositroy.CategoryRepos
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool Add(CategoryToAdd category)
        {
            var categorys = new Category
            {
                Name = category.Name,
            };
           
            _appDbContext.Categories.Add(categorys);
            _appDbContext.SaveChanges();
            return true;
        }

        public bool Update(int id, CategoryToAdd category)
        {

            var categorys = _appDbContext.Categories.Find(id);
            categorys.Name = category.Name;
            _appDbContext.Categories.Update(categorys);
            _appDbContext.SaveChanges();

            return true;
        }
    }
}
