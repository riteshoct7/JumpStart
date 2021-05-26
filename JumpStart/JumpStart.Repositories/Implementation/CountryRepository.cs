using JumpStart.Entities.Models;
using JumpStart.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JumpStart.Repositories.Implementation
{
    public class CountryRepository  : Repository<Country>,ICountryRepository
    {

        #region Constructors

        public CountryRepository(DbContext options) : base(options)
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
    }
}
