using JumpStart.Common;
using JumpStart.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace JumpStart.Web.Areas.User.Controllers
{
    [JumpStartAuhtorize(Roles = Constants.UserRoleTitle)]
    [Area(Constants.UserRoleTitle)]
    public class BaseController : Controller
    {
        
    }
}
