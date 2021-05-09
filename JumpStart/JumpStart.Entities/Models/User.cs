using Microsoft.AspNetCore.Identity;
using System;

namespace JumpStart.Entities.Models
{
    public class User : IdentityUser<int>
    {

        #region Properties

        public string FirstName { get; set; }

        public string MiddleInitials { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsSubcribedToPromotions { get; set; }

        public bool IsAgreeToTermsConditions { get; set; }

        public string PhoneNo { get; set; } 

        #endregion

    }
}
