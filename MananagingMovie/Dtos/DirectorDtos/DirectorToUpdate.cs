using MananagingMovie.Dtos.MovieDtos;
using MananagingMovie.Dtos.NationalityDtos;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.DirectorDtos
{
    public class DirectorToUpdate
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; } 
        [EmailAddress]
        public string Email { get; set; }

        public IList<int>? movieIds { get; set; }
    }
}
