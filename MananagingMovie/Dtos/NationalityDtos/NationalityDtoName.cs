using MananagingMovie.Dtos.DirectorDtos;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.NationalityDtos
{
    public class NationalityDtoName
    {
        [Required]
        public string Name { get; set; } = string.Empty;

     
    }
}
