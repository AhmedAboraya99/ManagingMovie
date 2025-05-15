using MananagingMovie.Dtos.CatgegoryDtos;
using MananagingMovie.Repositroy.CategoryRepos;
using MananagingMovie.Repositroy.MoiveRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MananagingMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepo _category;

        public CategoriesController(ICategoryRepo category)
        {
            _category = category;
        }
        [HttpPost]
        public IActionResult AddData(CategoryToAdd category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _category.Add(category);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateData(int id ,CategoryToAdd category)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _category.Update(id , category);
            return Ok();
        }
    }
}
