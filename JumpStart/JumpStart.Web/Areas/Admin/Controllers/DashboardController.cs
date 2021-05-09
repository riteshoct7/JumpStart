using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JumpStart.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
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
