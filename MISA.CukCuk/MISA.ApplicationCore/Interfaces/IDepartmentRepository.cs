using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface danh mục phòng ban
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        /// <summary>
        /// Lấy danh mục phòng ban theo mã phòng ban
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        /// createdby ngochtb(01/12/2020)
        Department GetDepartmentById(string departmentId);
    }
}
