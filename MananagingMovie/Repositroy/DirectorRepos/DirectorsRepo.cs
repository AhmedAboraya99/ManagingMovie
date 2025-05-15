using MananagingMovie.Data;
using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace MananagingMovie.Repositroy.DirectorRepos
{
    public class DirectorsRepo : IDirectorsRepo
    {
        private readonly AppDbContext _appDbContext;
        public DirectorsRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool Add(DirectorsToAdd directordDto)
        {

            try
            {
                var director = new Director
                {
                    Contact = directordDto.Contact,
                    Name = directordDto.Name,
                    Email = directordDto.Email,
                    nationality = new Nationality
                    {
                        Name = directordDto.NationalityName.Name,
                    }

                };
               _appDbContext.Directors.Add(director);
               _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }

        }

        public bool Delete(int id, int movieId)
        {
            var directors = _appDbContext.Directors.Include(d => d.movies).SingleOrDefault(x => x.Id == id);
            var movie = _appDbContext.Movies.Find(movieId) ;
            if (directors == null)
                return false;
            directors.movies.Remove(movie);
            _appDbContext.SaveChanges();
            return true;
        }

        public bool Update(int id, DirectorToUpdate directordDto)
        {
            var Movies = _appDbContext.Movies.Where(x => directordDto.movieIds.Contains(x.Id));
            if (Movies != null)
            {
                var director = _appDbContext.Directors.Include(d => d.movies).SingleOrDefault(x => x.Id == id);
                if(director != null)
                {
                    director.Name = directordDto.Name;
                    director.Email = directordDto.Email;
                    director.Contact = directordDto.Contact;
                    

                    director.movies.Clear();
                    foreach (var movie in Movies)
                        {

                            director.movies.Add(movie);
                        
                        }
                    _appDbContext.Directors.Update(director);
                    _appDbContext.SaveChanges();
                    return true;
                }
            }
            return false;

 
        }
    }
}
