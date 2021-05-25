using System.ComponentModel.DataAnnotations;

namespace JumpStart.Web.ViewModels
{
    public class SignUpViewModel
    {
        #region Properties

        [Required(ErrorMessage = "Email Required")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "InValidEmail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password And Confirm Password Do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Subscrtibe For Promotions")]
        public bool SubscribedForPromotions { get; set; }

        [Display(Name = "Accept Terms and Conditions")]
        public bool AcceptedTermsCondition { get; set; }

        #endregion
    }
}
