using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroToWebApi_B.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string role { get; set; }

    }
}
