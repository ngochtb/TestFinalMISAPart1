using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface IEmployeeService:IBaseService<Employee>
    {
        /// <summary>
        /// Lấy danh sách nhân viên theo phòng ban
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Danh sách nhân viên</returns>
        /// createdby ngochtb(01/12/2020)
        IEnumerable<Employee> GetEmployeesByDepartment(Guid departmentId);
        /// <summary>
        /// Lấy danh sách nhân viên theo chức vụ
        /// </summary>
        /// <param name="positionId"></param>
        /// <returns>Danh sách nhân viên</returns>
        /// createdby ngochtb(01/12/2020)
        IEnumerable<Employee> GetEmployeesByPosition(Guid positionId);

        /// <summary>
        /// hàm lọc theo các trường
        /// </summary>
        /// <param name="specs">Họ tên , số điện thoại, mã</param>
        /// <param name="DepartmentId">mã phòng ban</param>
        /// <param name="PossitionId">mã vị chí chức vụ</param>
        /// <returns></returns>
        IEnumerable<Employee> GetEntityFilter(string specs, string DepartmentId, string PossitionId);
        /// <summary>
        /// hàm lấy mã nhân viên lớn nhất
        /// </summary>
        /// <returns>string</returns>
        public string GetMaxEmployeeCode();
    }
}
