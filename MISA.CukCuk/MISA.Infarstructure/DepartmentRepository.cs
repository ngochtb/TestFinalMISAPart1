using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.Infarstructure
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        #region DECLARE
        #endregion

        public DepartmentRepository(IConfiguration configuration) : base(configuration)
        {
        }

        //public override IEnumerable<Department> GetEntities()
        //{
        //    return base.GetEntities("Proc_Departments");
        //}

        public Department GetDepartmentById(string departmentId)
        {
            return _dbConnection.Query<Department>("Proc_GetDepartmentById").FirstOrDefault();
        }
    }
}
