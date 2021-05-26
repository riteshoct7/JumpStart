using JumpStart.Entities.Models;
using JumpStart.Entities.Models.SPModels;
using System.Collections.Generic;

namespace JumpStart.Services.Interfaces
{
    public interface IStoredProcedureService
    {
        List<Country> GetAllCountries(int countryId);
        List<ExpenseDetailsSPModel> GetExpenseDetailsByCategory(int id);
    }
}
