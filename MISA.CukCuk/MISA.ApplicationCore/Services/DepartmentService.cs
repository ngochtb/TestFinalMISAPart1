using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    public class DepartmentService : BaseService<Department>, IDepartmentService
    {
        IDepartmentRepository _departmentRepository;
        public DepartmentService(IBaseRepository<Department> departmentRepository) : base(departmentRepository)
        {
         /*   _departmentRepository = departmentRepository;*/
        }

    }
}
