using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Movie>? movies { get; set; }
    }
}
