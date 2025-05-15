using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Repositroy.CategoryRepos;
using MananagingMovie.Repositroy.NationalityRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MananagingMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalitiesController : ControllerBase
    {
        private readonly INationalityRepo _nationality;

        public NationalitiesController(INationalityRepo nationality)
        {
            _nationality = nationality;
        }
        [HttpDelete]
        public IActionResult DeleteData(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var delete = _nationality.Delete(id);
            if (delete != false)
                return Ok();
            return BadRequest();
        }
        [HttpPost]
        public IActionResult AddData(NationalityToAdd nationality)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _nationality.Add(nationality);
            return Created();
        }
    }
}
