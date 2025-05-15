using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;

       // public int categoryId { get; set; }
        public Category category { get; set; } = new Category();
        public ICollection<Director>? directors { get; set; }
    }
}
