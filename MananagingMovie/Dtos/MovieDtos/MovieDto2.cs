using MananagingMovie.Dtos.CatgegoryDtos;

namespace MananagingMovie.Dtos.MovieDtos
{
    public class MovieDto2
    {
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public CategoryName? categoryDto { get; set; }
    }
}
