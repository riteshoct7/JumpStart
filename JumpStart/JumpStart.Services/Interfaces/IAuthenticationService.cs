using JumpStart.Entities.Models;
using System.Threading.Tasks;

namespace JumpStart.Services.Interfaces
{
    public interface IAuthenticationService
    {
        #region Methods

        User Login(string userName, string password, bool rememberMe);

        Task<bool> SignUp(User user, string password);

        User GetUser(string userName);

        Task<bool> SignOut();

        #endregion
    }
}
