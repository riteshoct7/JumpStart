using JumpStart.Entities.Models.SPModels;
using JumpStart.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStart.Repositories.Implementation
{
    public class StoredProcedureRepository : IStoredProcedureRepository
    {

        #region Constructors

        public StoredProcedureRepository(DbContext options) 
        {

        }

        #endregion

        public List<GetCountrySPModel> GetCountries(int countryId)
        {
            using (JumpStartDbContext context = new JumpStartDbContext())
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@CountryId", SqlDbType.Int) { Value = countryId });

                //List<GetCountrySPModel> lstCountries = new List<GetCountrySPModel>();
                //= context.Database.ExecuteSqlCommand("usp_GetUsersByRole @Role"
                //, parameters.ToArray()).ToListAsync().Result;


                //List<GetCountrySPModel> lstCountries = context.Database.ExecuteSqlRaw("exec usp_GetCountry @CountryId", parameters.ToArray());
                //List<GetCountrySPModel> lstCountries = context.Database.ExecuteSqlRaw<GetCountrySPModel>("exec usp_GetCountry @CountryId", parameters.ToArray()).ToList();


                //return lstCountries;
            }
            throw new NotImplementedException();
        }
    }
}
