using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.CatgegoryDtos
{
    public class CategoryName
    {
        [Required]
        public string? Name { get; set; }
    }
}
