using AutoMapper;
using JumpStart.Services.Interfaces;
using JumpStart.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace JumpStart.Web.Controllers
{
    public class ContactUs : Controller
    {

        #region Properties

        private readonly IContactUsService contactUsService;
        private readonly IMapper mapper;

        #endregion

        #region Constructors

        public ContactUs(IContactUsService contactUsService, IMapper mapper)
        {
            this.contactUsService = contactUsService;
            this.mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactUseViewModel model)
        {
            if (ModelState.IsValid)
            {
                JumpStart.Entities.Models.ContactUs objContactUs = mapper.Map<JumpStart.Entities.Models.ContactUs>(model);
                
                contactUsService.Add(objContactUs);
                return RedirectToAction("Contact");
            }
            return View(model);
        }

        #endregion

    }
}
