using JumpStart.Entities.Models.SPModels;
using System.Collections.Generic;

namespace JumpStart.Repositories.Interfaces
{
    public interface IStoredProcedureRepository
    {
        #region Methods
        List<GetCountrySPModel> GetCountries(int countryId); 

        #endregion
    }
}
