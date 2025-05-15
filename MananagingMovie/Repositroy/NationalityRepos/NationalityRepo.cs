using MananagingMovie.Data;
using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace MananagingMovie.Repositroy.NationalityRepos
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly AppDbContext _appDbContext;
        public NationalityRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
           
        }
        public bool Add(NationalityToAdd nationality)
        {
            var national = new Nationality
            {
                Name = nationality.Name,

            };
            _appDbContext.Nationalities.Add(national);
            var state = _appDbContext.SaveChanges();
            if (state == 0)
                return false;
            else
                return true;
        }

        public bool Delete(int id)
        {
            var na = _appDbContext.Nationalities.FirstOrDefault(x => x.Id == id);
            if (na == null)
                return false;
            else
            {
                _appDbContext.Nationalities.Remove(na);
                _appDbContext.SaveChanges();
                return true;
                
            }
        }

        public bool Deletedirector(int id)
        {
            var res = _appDbContext.Nationalities.Include(x => x.director).FirstOrDefault(x => x.Id == id);
                if (res != null)
                {
                _appDbContext.Nationalities.Remove(res);
                _appDbContext.SaveChanges();
                return true;
                }
            return false;
        }
    }
}
