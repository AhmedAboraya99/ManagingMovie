using MananagingMovie.Dtos.NationalityDtos;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.DirectorDtos
{
    public class DirectorsToAdd
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone]
        public string Contact { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public NationalityDtoName? NationalityName { get; set; }
        
    }
}
