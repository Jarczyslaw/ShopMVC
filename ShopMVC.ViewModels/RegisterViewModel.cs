using System.ComponentModel.DataAnnotations;

namespace ShopMVC.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Insert valid email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insert password")]
        [DataType(DataType.Password)]
        [StringLength(30)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password")]
        [DataType(DataType.Password)]
        [StringLength(20)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Please confirm inserted password")]
        public string ConfirmPassword { get; set; }
    }
}