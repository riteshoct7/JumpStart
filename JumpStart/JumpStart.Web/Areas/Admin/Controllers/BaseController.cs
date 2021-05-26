using JumpStart.Common;
using JumpStart.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace JumpStart.Web.Areas.Admin.Controllers
{

    [JumpStartAuhtorize(Roles = Constants.AdminRoleTitle)]
    [Area(Constants.AdminRoleTitle)]
    public class BaseController : Controller
    {
        
    }
}
