using JumpStart.Entities.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace JumpStart.Repositories.Interfaces
{
    public interface IAuthenticationRepostiory
    {
        #region Methods

        User Login(string userName, string password, bool rememberMe);

        Task<bool> SignUp(User user, string password);

        User GetUser(string userName);

        Task<bool> SignOut();
       
        #endregion
    }
}
