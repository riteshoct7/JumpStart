using JumpStart.Entities.Models;
using JumpStart.Entities.Models.SPModels;
using System.Collections.Generic;

namespace JumpStart.Repositories.Interfaces
{
    public interface IStoredProcedureRepository
    {
        #region Methods
        List<Country> GetCountries(int countryId);
        List<ExpenseDetailsSPModel> GetExpenseDetailsByCategory(int id);

        #endregion
    }
}
