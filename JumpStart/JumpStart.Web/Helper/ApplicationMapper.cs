using AutoMapper;
using JumpStart.Entities.Models;
using JumpStart.Web.Areas.Admin.Models;
using JumpStart.Web.ViewModels;

namespace JumpStart.Web.Helper
{
    public class ApplicationMapper : Profile
    {
        #region Constructors

        public ApplicationMapper()
        {
            CreateMap<ContactUseViewModel, ContactUs>().ReverseMap();
            CreateMap<ContactUsModel, ContactUs>().ReverseMap();
            CreateMap<SignUpViewModel, User>().ReverseMap();
        }

        #endregion
    }
}
