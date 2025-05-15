using MananagingMovie.Dtos.CatgegoryDtos;
using MananagingMovie.Dtos.DirectorDtos;
using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Dtos.MovieDtos
{
    public class movieadd
    {
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public ICollection<directoraddmovie>? directorsDto { get; set; }
    }

    public class directoraddmovie
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone]
        public string Contact { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
