using System.ComponentModel.DataAnnotations;

namespace Mission06_Bundy.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
       
    }
}
