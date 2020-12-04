using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MISA.Infarstructure
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        #region DECLARE
        #endregion

        public EmployeeRepository(IConfiguration configuration):base(configuration)
        {
        }

        public IEnumerable<Employee> GetEntityFilter(string specs, string DepartmentId, string PossitionId)
        {
            var parameter = new DynamicParameters();
            parameter.Add("PropertyValue", specs != null ? specs : String.Empty, DbType.String);
            parameter.Add("DepartmentID", DepartmentId, DbType.String);
            parameter.Add("PossitionID", PossitionId, DbType.String);
            var data = _dbConnection.Query<Employee>("Proc_GetEmployeesFilter", parameter,commandType: CommandType.StoredProcedure).ToList();
            return data;
        }

        public string GetMaxEmployeeCode()
        {
            var result = _dbConnection.ExecuteScalar<string>("SELECT MAX(e.EmployeeCode) FROM Employee e;", commandType: CommandType.Text);
            return result;
        }

        //public override IEnumerable<Employee> GetEntities()
        //{
        //    return base.GetEntities("Proc_GetEmployees");   
        //}

    }
}
