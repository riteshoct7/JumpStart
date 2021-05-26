using JumpStart.Entities.Models;
using JumpStart.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JumpStart.Repositories.Implementation
{
    public class AuthenticationRepostiory : IAuthenticationRepostiory
    {
        #region Properties

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<Role> roleManager;

        #endregion

        #region Constructors

        public AuthenticationRepostiory(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        #endregion

        #region Methods

        public User GetUser(string userName)
        {
            return userManager.FindByNameAsync(userName).Result;
        }

        public User Login(string userName, string password,bool rememberMe)
        {
            var result = signInManager.PasswordSignInAsync(userName, password, rememberMe, false).Result;

            if (result.Succeeded)
            {
                var user = userManager.FindByNameAsync(userName).Result;
                var roles = userManager.GetRolesAsync(user).Result;
                user.Roles = roles.ToArray();
                return user;
            }
            return null;
        }
   
        public async Task<bool> SignOut()
        {
            try
            {
                await signInManager.SignOutAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SignUp(User user, string password)
        {
            var result = userManager.CreateAsync(user, password).Result;
            if (result.Succeeded)
            {
                
                if (!roleManager.RoleExistsAsync(Common.Constants.UserRoleTitle).Result)
                {
                    Role objRole = new Role();
                    objRole.Name = Common.Constants.UserRoleTitle;
                    objRole.NormalizedName = Common.Constants.UserRoleTitle;
                    objRole.Description = Common.Constants.UserRoleTitle;                    
                    await roleManager.CreateAsync(objRole);
                }
                var roleResult = userManager.AddToRoleAsync(user, Common.Constants.UserRoleTitle).Result;                
                if (roleResult.Succeeded)
                {
                    return true;
                }
            }
            return false;
        }
    

        #endregion
    }
}
