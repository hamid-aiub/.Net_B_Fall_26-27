using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroToEF_B.Models
{
    [Table("products")]
    public class Product
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        public string? description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public double price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        public int stock { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string category { get; set; }
    }
}