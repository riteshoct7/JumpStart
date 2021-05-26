using JumpStart.Entities.Models;
using JumpStart.Entities.Models.SPModels;
using JumpStart.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JumpStart.Repositories.Implementation
{
    public class StoredProcedureRepository : IStoredProcedureRepository
    {

        #region Constructors

        public StoredProcedureRepository(DbContext options) 
        {

        }

        #endregion

        public List<Country> GetCountries(int countryId)
        {
            using (JumpStartDbContext context = new JumpStartDbContext())
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@CountryId", SqlDbType.Int) { Value = countryId });
                string sql = "exec usp_GetCountry @CountryId";                
                var result = context.Countries.FromSqlRaw(sql, parameters.ToArray());
                return result.ToList();
            }
            
        }
        public List<ExpenseDetailsSPModel> GetExpenseDetailsByCategory(int id)
        {
            using (JumpStartDbContext context = new JumpStartDbContext())
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@ExpenseCategoryId", SqlDbType.Int) { Value = id });
                string sql = "exec usp_ExpenseDetails @ExpenseCategoryId";
                var result = context.ExpenseDetailsSPModel.FromSqlRaw(sql,parameters.ToArray()); 
                return result.ToList();
            }
        }
    }
}
