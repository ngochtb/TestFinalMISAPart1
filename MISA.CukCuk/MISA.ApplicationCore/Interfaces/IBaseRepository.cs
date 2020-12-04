using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        IEnumerable<TEntity> GetEntities();
        //IEnumerable<TEntity> GetEntities(string storeName);
        /// <summary>
        /// Lấy dữ liệu theo id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        TEntity GetEntityById(Guid employeeId);
        /// <summary>
        /// Thêm bản ghi
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        int Add(TEntity employee);
        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        int Update(TEntity employee);
        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        int Delete(Guid employeeId);
        /// <summary>
        /// Lấy dữ liệu theo thuộc tính
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        /// createdby ngochtb(02/12/2020)
        TEntity GetEntityByProperty(TEntity entity, PropertyInfo property);
    }
}
