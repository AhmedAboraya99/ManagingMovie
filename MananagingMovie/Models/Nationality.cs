using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
       
        public Director? director { get; set; }
    }
}
