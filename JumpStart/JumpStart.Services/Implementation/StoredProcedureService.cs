using JumpStart.Entities.Models;
using JumpStart.Entities.Models.SPModels;
using JumpStart.Repositories.Interfaces;
using JumpStart.Services.Interfaces;
using System.Collections.Generic;

namespace JumpStart.Services.Implementation
{
    public class StoredProcedureService : IStoredProcedureService
    {
        #region Properties

        private readonly IStoredProcedureRepository storedProcedureRepository;

        #endregion

        #region Constructors
        public StoredProcedureService(IStoredProcedureRepository storedProcedureRepository)
        {
            this.storedProcedureRepository = storedProcedureRepository;
        }
        #endregion

        #region Methods
        public List<Country> GetAllCountries(int countryId)
        {
            return storedProcedureRepository.GetCountries(countryId);
        }

        public List<ExpenseDetailsSPModel> GetExpenseDetailsByCategory(int id)
        {
            return storedProcedureRepository.GetExpenseDetailsByCategory(id);
        }
        #endregion
    }
}
