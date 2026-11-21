using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First_B.Models
{
    [Table("students")]
    public class Student
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage ="Name is mandtatory")]
        [StringLength(50)]
        public string  name { get; set; }

        //[Required(ErrorMessage ="Department is required")]
        //[StringLength(30)]
        public string? department { get; set; }
        [EmailAddress(ErrorMessage ="This is not valid")]

        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [StringLength(30)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\w\\s]).{8,}$", ErrorMessage="Please provide a strong password")]
        public string password { get; set; }



    }
}
