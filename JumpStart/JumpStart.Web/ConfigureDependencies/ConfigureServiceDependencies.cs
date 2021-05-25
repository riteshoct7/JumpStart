using JumpStart.Services.Implementation;
using JumpStart.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace JumpStart.Web.ConfigureDependencies
{
    public  class ConfigureServiceDependencies
    {
        #region Methods

        public static void AddServices(IServiceCollection services)               
        {
            services.AddTransient<IContactUsService, ContactUsService>();
            services.AddTransient<IAuthenticateService, AuthenticateService>();
            services.AddTransient<Services.Interfaces.IAuthenticationService, Services.Implementation.AuthenticationService>();
        } 

        #endregion
    }
}
