using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroToEF_B.Models
{
    public class AllowedPrice: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                double price = (double)value;
                if(price <= 0)
                {
                    return new ValidationResult(ErrorMessage ?? "Please provide a valid price");
                }
            }
            return ValidationResult.Success;
        }
    }

    public class AllowStock:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            if (value != null)
            {
                int stock = (int)value;
                if (stock <= 0)
                {
                    return new ValidationResult(ErrorMessage ?? "Please provide a valid stock number");
                }
            }
            return ValidationResult.Success;
        }
    }

    [Table("products")]
    public class Product
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        public string? description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [AllowedPrice(ErrorMessage ="Price should be more than 0")]
        public double? price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        [AllowStock(ErrorMessage = "Stock should be more than 0")]
        public int? stock { get; set; }

        [Required(ErrorMessage = "Category is required")]

        public string category { get; set; }
    }
}