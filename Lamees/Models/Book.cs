using System.ComponentModel.DataAnnotations;

namespace Lamees.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string title { get; set; }
        
        [Required]
        [StringLength(255)]
        public string author { get; set; }

        [StringLength(255)]
        public string desc { get; set; }
        
        [Required]
        [StringLength(255)]
        public string image { get; set; }

        [Required]
        public double price { get; set; }

    }
}