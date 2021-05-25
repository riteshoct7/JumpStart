using JumpStart.Entities.Models;
using JumpStart.Repositories.Interfaces;
using JumpStart.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace JumpStart.Services.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        #region Properties

        private readonly IAuthenticationRepostiory authenticateRepository;

        #endregion

        #region Constructors
        public AuthenticationService(IAuthenticationRepostiory authenticateRepository)
        {
            this.authenticateRepository = authenticateRepository;
        }
        #endregion

        #region Methods
        public User GetUser(string userName)
        {
            return authenticateRepository.GetUser(userName);
        }

        public User Login(string userName, string password, bool rememberMe)
        {
            return authenticateRepository.Login(userName,password, rememberMe);
        }

        public Task<bool> SignOut()
        {
            return authenticateRepository.SignOut();
        }

        public Task<bool> SignUp(User user, string password)
        {
            return authenticateRepository.SignUp(user,password);
        } 

        #endregion

    }
}
