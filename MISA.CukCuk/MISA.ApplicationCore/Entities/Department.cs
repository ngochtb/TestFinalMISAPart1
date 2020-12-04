using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Phòng ban
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public class Department: BaseEntity
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Mã phòng ban
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        public string DepartmentCode { get; set; }
        /// <summary>
        /// Tên phòng ban
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        public string DepartmentName { get; set; }
    }
}
