using Microsoft.AspNetCore.Mvc;

namespace JumpStart.Web.Areas.Admin.Controllers
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
