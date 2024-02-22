using System.ComponentModel.DataAnnotations;

namespace Mission06_Bundy.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
