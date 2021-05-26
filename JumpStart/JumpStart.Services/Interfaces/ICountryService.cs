using JumpStart.Entities.Models;
using System.Collections.Generic;

namespace JumpStart.Services.Interfaces
{
    public interface ICountryService
    {
        #region Methods
        IEnumerable<Country> GetAllRecords(); 

        #endregion
    }
}
