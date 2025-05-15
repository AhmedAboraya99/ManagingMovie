using MananagingMovie.Dtos.NationalityDtos;
using MananagingMovie.Models;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.MovieDtos
{
    public class MovieToGet
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public CategoryMovieGet? category { get; set; }
        public IList<DirectorMovieGet>? directors { get; set; }
    }

    public class CategoryMovieGet
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
    public class DirectorMovieGet
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public NationalityDtoName? nationalityDto { get; set; }
    }
}
