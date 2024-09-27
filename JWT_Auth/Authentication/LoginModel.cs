using System.ComponentModel.DataAnnotations;
namespace JWT_Auth.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage ="username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="password is required")]
        public string Password { get; set; }
    }
}
