using JumpStart.Services.Implementation;
using JumpStart.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JumpStart.Web.ConfigureDependencies
{
    public  class ConfigureServiceDependencies
    {
        #region Methods

        public static void AddServices(IServiceCollection services)               
        {
            // Specify Services
            services.AddTransient<IContactUsService, ContactUsService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IAuthenticateService, AuthenticateService>();
            services.AddTransient<IStoredProcedureService, StoredProcedureService>();
            services.AddTransient<Services.Interfaces.IAuthenticationService, Services.Implementation.AuthenticationService>();

            //Add Auto Mapper 
            services.AddAutoMapper(typeof(Startup));

        } 

        #endregion
    }
}
