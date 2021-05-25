using Microsoft.AspNetCore.Mvc;

namespace JumpStart.Web.Areas.User.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
