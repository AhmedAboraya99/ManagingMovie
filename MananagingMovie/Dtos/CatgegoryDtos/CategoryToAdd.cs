using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.CatgegoryDtos
{
    public class CategoryToAdd
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
