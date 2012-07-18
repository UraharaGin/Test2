using System.ComponentModel.DataAnnotations;

namespace Test.Test.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword")]
        public string ConfirmPassword { get; set; } 
    }
}