using System;
using System.ComponentModel.DataAnnotations;

namespace MVAMVC.Models
{
    public class RegisterUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 4)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Date registered")]
        [DataType(DataType.DateTime)]
        public DateTime DateRegistered { get; set; }
    }
}
