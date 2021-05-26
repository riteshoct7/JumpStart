using JumpStart.Entities.Models;
using JumpStart.Repositories;
using JumpStart.Repositories.Implementation;
using JumpStart.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JumpStart.Services.ConfigureDependencies
{
    public class ConfigureRepositoryDependencies
    {
        #region Methods
        public static void AddServices(IServiceCollection services, IConfiguration Configuration)
        {

            //specify induction for repository
            services.AddTransient<IContactUsRepository, ContactUsRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IStoredProcedureRepository, StoredProcedureRepository>();
            services.AddTransient<IAuthenticationRepostiory, AuthenticationRepostiory>();

            //specify for database
            services.AddDbContext<JumpStartDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultDbConnection"))
            );
            //specify for database
            services.AddTransient<DbContext, JumpStartDbContext>();

            //specify for identity framwork
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<JumpStartDbContext>()
                .AddDefaultTokenProviders();


            //specify for identity framwork password complexity
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
            });


        } 

        #endregion
    }
}
