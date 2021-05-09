using AutoMapper;
using JumpStart.Services.Interfaces;
using JumpStart.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JumpStart.Web.Controllers
{
    public class AccountsController : Controller
    {

        #region Properties

        private readonly IAuthenticateService authenticateService;
        private readonly IMapper mapper;

        #endregion

        #region Constructors

        public AccountsController(IAuthenticateService authenticateService, IMapper mapper)
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
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            return View();
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
        public IActionResult LogOut()
        {
            return View();
        }

        #endregion

    }
}
