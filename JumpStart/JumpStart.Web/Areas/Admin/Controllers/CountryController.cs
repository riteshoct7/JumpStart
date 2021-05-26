using JumpStart.Entities.Models;
using JumpStart.Entities.Models.SPModels;
using JumpStart.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JumpStart.Web.Areas.Admin.Controllers
{
    public class CountryController : BaseController
    {

        #region Properties

        private readonly ICountryService countryService;
        private readonly IStoredProcedureService storedProcedureService;

        #endregion

        #region Constructors
        public CountryController(ICountryService countryService, IStoredProcedureService storedProcedureService)
        {
            this.countryService = countryService;
            this.storedProcedureService = storedProcedureService;
        }
        #endregion

        #region Methods
        public IActionResult List()
        {
            //IEnumerable<Country> lst = countryService.GetAllRecords();
            List<Country> lstCountry = storedProcedureService.GetAllCountries(0);
            List<ExpenseDetailsSPModel> lstExpense = storedProcedureService.GetExpenseDetailsByCategory(0);
            return View(lstCountry);
        } 
        #endregion
    }
}
