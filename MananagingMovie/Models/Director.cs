using System.ComponentModel.DataAnnotations;

namespace MananagingMovie.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone]
        public string Contact { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty; 

        public int? NationalityId { get; set; }
        public Nationality? nationality { get; set; }   

        public ICollection<Movie>? movies { get; set; }

    }
}
