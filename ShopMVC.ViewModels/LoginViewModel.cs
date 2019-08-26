using System.ComponentModel.DataAnnotations;

namespace ShopMVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Insert valid email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insert password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}