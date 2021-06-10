using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string title { set; get; }

        [Required]
        public string desc { set; get; }

        [Required]
        public string author { set; get; }
       
        [Required]
        public string image { set; get; }
        
        [Required]
        public double price { set; get; }
        
    }
}