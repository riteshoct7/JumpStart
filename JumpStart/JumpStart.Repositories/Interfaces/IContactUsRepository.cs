using JumpStart.Entities.Models;

namespace JumpStart.Repositories.Interfaces
{
    public interface IContactUsRepository :IRepository<ContactUs>
    {

        #region Methods

        ContactUs GetByFirstName(string firstName);

        ContactUs GetByLastName(string lastName); 

        #endregion

    }
}
