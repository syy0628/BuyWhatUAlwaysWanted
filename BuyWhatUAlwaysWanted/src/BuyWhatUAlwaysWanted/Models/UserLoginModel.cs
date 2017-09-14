using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuyWhatUAlwaysWanted.Models
{
    public class UserLoginModel

    {
        public long UserID { get; set; }
        
        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

    }
}
