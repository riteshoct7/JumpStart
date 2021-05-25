using System.ComponentModel.DataAnnotations;

namespace JumpStart.Web.ViewModels
{
    public class LoginViewModel
    {

        [Required (ErrorMessage ="User Name  Required")]
        [Display(Name =("User Name"))]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = ("Remember Me"))]
        public bool RememberMe { get; set; }
    }

}
