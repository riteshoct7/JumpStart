using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public string[] Roles { get; set; }

        #endregion

    }
}
