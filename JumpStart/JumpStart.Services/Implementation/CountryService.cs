using JumpStart.Entities.Models;
using JumpStart.Repositories.Interfaces;
using JumpStart.Services.Interfaces;
using System.Collections.Generic;

namespace JumpStart.Services.Implementation
{
    public class CountryService : ICountryService
    {
        #region Properties

        private readonly ICountryRepository countryRepository;

        #endregion

        #region Constructors

        public CountryService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        #endregion

        #region Methods
        public IEnumerable<Country> GetAllRecords()
        {
            return countryRepository.GetAll();
        } 
        #endregion
    }
}
