using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Models;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.NationalityDtos
{
    public class NationalityDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public DirectorDto? directorDto { get; set; }
    }
}
