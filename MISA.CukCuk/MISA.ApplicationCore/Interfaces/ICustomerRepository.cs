using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface danh mục khách hàng
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        /// <summary>
        /// Lấy thông tin khách hàng theo mã khách hàng
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        /// createdby ngochtb(01/12/2020)
        Customer GetCustomerByCode(string customerCode);
    }
}
