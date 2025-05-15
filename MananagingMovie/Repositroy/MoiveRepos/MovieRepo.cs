using MananagingMovie.Data;
using MananagingMovie.Dtos.CatgegoryDtos;
using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Dtos.MovieDtos;
using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace MananagingMovie.Repositroy.MoiveRepos
{
    public class MovieRepo : IMovieRepo
    {
        private readonly AppDbContext _appDbContext;
        public MovieRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(movieadd MovieDto)
        {
            Movie movie = new Movie
            {
                Title = MovieDto.Title,
                Date = MovieDto.Date,
                directors = MovieDto.directorsDto.Select(x => new Director
                {
                    Name = x.Name,
                    Email = x.Email,
                    Contact = x.Contact,

                }).ToList()
            };
            _appDbContext.Movies.Add(movie);
            _appDbContext.SaveChanges();
          
        }



        public List<MovieToGet> GetAll()
        {
            var res = _appDbContext.Movies
                  .Include(m => m.directors)
                  .ThenInclude(d => d.nationality)
                  .Include(m => m.category)
                  .Select(x => new MovieToGet
                  {
                      Id = x.Id,
                      Date = x.Date,
                      Title = x.Title,
                      category = new CategoryMovieGet
                      {
                          Id = x.category.Id,
                          Name = x.category.Name,

                      },
                      directors = x.directors.Select(d => new DirectorMovieGet
                      {
                          Id = d.Id,
                          Email = d.Email,
                          Name = d.Name,
                          Contact = d.Contact,
                          nationalityDto = new NationalityDtoName
                          {
                              Name = d.nationality.Name
                          }
                      }
                          ).ToList()
                  }).ToList();
            return res;
         
        }

        public MovieDto GetById(int id)
        {

            var res = _appDbContext.Movies.Include(x => x.category).Include(x => x.directors).ThenInclude(x => x.nationality).FirstOrDefault(x=>x.Id== id);
            var dd = new MovieDto
            {
                Title = res.Title,
                Date = res.Date,
                categoryDto = new CategoryName
                {
                    Name = res.category.Name


                },
                directorsDto = res.directors.Select(d => new DirectorMovies
                {
                    Contact = d.Contact,
                    Name = d.Name,
                    Email = d.Email,
                    Nationality= new NationalityDtoName
                    {
                        Name= d.Name
                        
                    }

                }).ToList()


            };
            return dd;

        }

    }
}
