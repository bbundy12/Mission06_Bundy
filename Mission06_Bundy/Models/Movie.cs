using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Bundy.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string? Director { get; set; }
        public int Year { get; set; }
        public string? Rating { get; set; }
        public string Edited { get; set; }
        public string? LentTo { get; set; }
        public string CopiedToPlex { get; set; }
        public string? Notes { get; set; }
       
    }
}
