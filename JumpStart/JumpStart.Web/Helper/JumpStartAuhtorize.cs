using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace JumpStart.Web.Helper
{
    public class JumpStartAuhtorize : Attribute, IAuthorizationFilter
    {
        #region Properties
        public string Roles { get; set; }

        #endregion

        #region Methods

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (!context.HttpContext.User.IsInRole(Roles))
                {
                    context.Result = new RedirectToActionResult("Unauthorize", "Accounts", new { area = "" });
                }
            }
            else
            {
                context.Result = new RedirectToActionResult("Login", "Accounts", new { area = "" });
            }
        } 

        #endregion
    }
}
