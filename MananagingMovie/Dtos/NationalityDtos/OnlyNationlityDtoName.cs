using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.NationalityDtos
{
    public class OnlyNationlityDtoName
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
