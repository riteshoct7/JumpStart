using Microsoft.AspNetCore.Mvc;

namespace JumpStart.Web.Areas.User.Controllers
{

    public class DashboardController : BaseController
    {
        #region Constructors
        public DashboardController()
        {

        }
        #endregion

        #region Methods
        public IActionResult Index()
        {
            return View();
        } 
        #endregion
    }
}
