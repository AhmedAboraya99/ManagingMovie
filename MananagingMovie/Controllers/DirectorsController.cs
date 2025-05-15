using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Repositroy.DirectorRepos;
using MananagingMovie.Repositroy.MoiveRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MananagingMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorsRepo _DirectorRepo;

        public DirectorsController(IDirectorsRepo DirectorRepo)
        {
            _DirectorRepo = DirectorRepo;
        }
        [HttpPost]
        public IActionResult AddData(DirectorsToAdd directors)
        {
            if (!ModelState.IsValid)
                return BadRequest();
             var added = _DirectorRepo.Add(directors);
            if(added == false)
            {
                return BadRequest();
              
            }
               
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateData(int id , DirectorToUpdate directors)
        {

            var state= _DirectorRepo.Update(id,directors);
            if(state == true)
                return Ok();
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public IActionResult DeleteData(int id, int movieId) { 
            if (!ModelState.IsValid)
                return BadRequest();

            var delete = _DirectorRepo.Delete(id, movieId);
            if(delete != false)
                    return Ok();

            return BadRequest();
        }
    }
}
