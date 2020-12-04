using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Vị trí
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public class Possition: BaseEntity
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        public Guid PossitionId { get; set; }
        /// <summary>
        /// Mã vị trí
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        public string PossitionCode { get; set; }
        /// <summary>
        /// Tên vị trí
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        public string PossitionName { get; set; }
    }
}
