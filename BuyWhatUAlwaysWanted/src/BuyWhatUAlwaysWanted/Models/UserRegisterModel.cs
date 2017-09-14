using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuyWhatUAlwaysWanted.Models
{
    public class UserRegisterModel
    {
        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        [Display(Name = "User Name")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 5,
            ErrorMessage = "User Name must be between 5 and 20 characters long")]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
