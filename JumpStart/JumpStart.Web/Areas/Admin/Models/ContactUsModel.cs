using System.ComponentModel.DataAnnotations;

namespace JumpStart.Web.Areas.Admin.Models
{
    public class ContactUsModel
    {

        #region Properties

        public int Id { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initials")]
        public string MiddleInitials { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Name Required")]
        public string Email { get; set; }

        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Subject Required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message Required")]
        public string Message { get; set; }

        public string Addreess { get; set; }

        public string Zip { get; set; }
        #endregion

    }
}
