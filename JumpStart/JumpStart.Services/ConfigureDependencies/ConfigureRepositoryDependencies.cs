using JumpStart.Entities.Models;
using JumpStart.Repositories;
using JumpStart.Repositories.Implementation;
using JumpStart.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStart.Services.ConfigureDependencies
{
    public class ConfigureRepositoryDependencies
    {
        public static void AddServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<IContactUsRepository, ContactUsRepository>();

            services.AddDbContextPool<JumpStartDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultDbConnection"))
            );

            services.AddIdentity<User, Role>().AddEntityFrameworkStores<JumpStartDbContext>()
                .AddDefaultTokenProviders();
            
            services.AddTransient<DbContext, JumpStartDbContext>();
        }
    }
}
