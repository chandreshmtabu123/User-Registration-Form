using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CrudApplication.Models.ViewModel
{
    public class SignUpUserViewModel
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter Valid Email")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number is not Valid.")]

        public long? Mobile { get; set; }
        
        [Required(ErrorMessage ="Please enter password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter Confirm Password")]
        [Compare("Password", ErrorMessage = ("confirm password can't matched!"))]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
        [Display(Name ="Active")]
        
        public bool IsActive { get; set; }
        


    }
}
