using MananagingMovie.Dtos.MovieDtos;
using MananagingMovie.Repositroy.MoiveRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MananagingMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _movieRepo;

        public MoviesController (IMovieRepo movieRepo)
        {
            _movieRepo = movieRepo;
        }
        [HttpGet]
        public IActionResult GetAllData()
        {
            var data = _movieRepo.GetAll();
            if (data == null)
                return NotFound();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetDataById(int id)
        {
            var data = _movieRepo.GetById(id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult AddData(movieadd movieDto)
        {    
            if (movieDto == null)
                return BadRequest();
            _movieRepo.Add(movieDto);
            return Created();
        }
    }
}
