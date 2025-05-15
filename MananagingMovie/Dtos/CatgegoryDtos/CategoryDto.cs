using MananagingMovie.Dtos.MovieDtos;
using MananagingMovie.Models;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.CatgegoryDtos
{
    public class CategoryDto
    {
            public int Id { get; set; }
            [Required]
            public string? Name { get; set; }

            public ICollection<MovieDto>? movies { get; set; }
        
    }


}
