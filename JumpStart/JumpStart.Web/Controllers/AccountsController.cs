using AutoMapper;
using JumpStart.Common;
using JumpStart.Entities.Models;
using JumpStart.Services.Interfaces;
using JumpStart.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace JumpStart.Web.Controllers
{
    public class AccountsController : Controller
    {

        #region Properties

        private readonly IAuthenticationService authenticateService;
        private readonly IMapper mapper;

        #endregion

        #region Constructors

        public AccountsController(IAuthenticationService authenticateService, IMapper mapper)
        {
            this.authenticateService = authenticateService;
            this.mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = authenticateService.Login(model.UserName, model.Password, model.RememberMe);
                if (user != null)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    

                    if (user.Roles.Contains(Constants.AdminRoleTitle))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else if (user.Roles.Contains(Constants.UserRoleTitle))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "User" });
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {        
            if (ModelState.IsValid)
            {
                User objUser = mapper.Map<User>(model);
                objUser.UserName = model.Email;
                objUser.CreatedDate = Util.GetCurrentDateTime();
                bool result = await authenticateService.SignUp(objUser, model.Password);
                if (result)
                {
                    return RedirectToAction("Login");
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await authenticateService.SignOut();
            return RedirectToAction("LogOutComplete");
        }   
        public IActionResult LogOutComplete()
        {
            return View();
        }

        public IActionResult Unauthorize()
        {
            return View();
        }

        #endregion

    }
}
