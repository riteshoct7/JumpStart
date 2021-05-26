using AutoMapper;
using JumpStart.Entities.Models;
using JumpStart.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JumpStart.Web.Areas.Admin.Controllers
{    
    public class ContactsController : BaseController
    {

        #region Properties

        private readonly IContactUsService contactUsService;
        private readonly IMapper mapper;

        #endregion

        #region Constrcutors

        public ContactsController(IContactUsService contactUsService, IMapper mapper)
        {
            this.contactUsService = contactUsService;
            this.mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult Contact()
        {
            IEnumerable<ContactUs> lstContactUs = contactUsService.GetAllRecords();
            IEnumerable<JumpStart.Web.Areas.Admin.Models.ContactUsModel> lstContacts = mapper.Map<IEnumerable<JumpStart.Web.Areas.Admin.Models.ContactUsModel>>(lstContactUs);
            return View(lstContacts);
        } 

        #endregion

    }
}
