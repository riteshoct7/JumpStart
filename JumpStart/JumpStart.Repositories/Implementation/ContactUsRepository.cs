using JumpStart.Entities.Models;
using JumpStart.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JumpStart.Repositories.Implementation
{
    public class ContactUsRepository : Repository<ContactUs>, IContactUsRepository
    {

        #region Constructors

        public ContactUsRepository(DbContext options) : base(options)
        {

        }

        #endregion

        #region Properties

        public JumpStartDbContext dbContext
        {
            get 
            {
                return context as JumpStartDbContext;
            }

        }

        #endregion

        #region Methods

        public ContactUs GetByFirstName(string firstName)
        {
            return dbContext.ContactUs.Where(x => x.FirstName == firstName).FirstOrDefault();
        }

        public ContactUs GetByLastName(string lastName)
        {
            return dbContext.ContactUs.Where(x => x.LastName == lastName).FirstOrDefault();
        } 

        #endregion

    }
}
