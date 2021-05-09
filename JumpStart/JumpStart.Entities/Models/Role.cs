using Microsoft.AspNetCore.Identity;

namespace JumpStart.Entities.Models
{
    public  class Role :IdentityRole<int>
    {

        #region Properties

        public string Description { get; set; } 

        #endregion

    }
}
