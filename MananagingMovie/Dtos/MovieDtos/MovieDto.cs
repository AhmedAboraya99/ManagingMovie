using MananagingMovie.Dtos.CatgegoryDtos;
using MananagingMovie.Dtos.DirectorDtos;
using MananagingMovie.Models;

namespace MananagingMovie.Dtos.MovieDtos
{
    public class MovieDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public CategoryName categoryDto { get; set; }
  
        public ICollection<DirectorMovies>? directorsDto { get; set; }
    }
}
