using MananagingMovie.Dtos.MovieDtos;
using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Models;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.DirectorDtos
{
    public class DirectorDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone]
        public string Contact { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public int NationalityId { get; set; }
        public NationalityDtoName? nationalityDto { get; set; }

        public ICollection<MovieDto2>? moviesDto { get; set; }
    }
}
