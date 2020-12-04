using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Enums
{
    /// <summary>
    /// MISACode để xác định trạng thái của việc validate
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public enum MISACode
    {
        /// <summary>
        /// Dữ liệu hợp lệ
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        IsValid = 100,

        /// <summary>
        /// Dữ liệu chưa hợp lệ
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        NotValid = 900,

        /// <summary>
        /// Thành công
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Success = 200,
        /// <summary>
        /// Thông báo lỗi
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Exception = 500
    }

    /// <summary>
    /// Xác định trạng thái của Object
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public enum EntityState
    {
        AddNew = 1,
        Update = 2,
        Delete = 3,
    }

    /// <summary>
    /// Thông tin giới tính
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public enum Gender {
        /// <summary>
        /// Nữ
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Female=0,

        /// <summary>
        /// Nam
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Male=1,

        /// <summary>
        /// Chưa xác định
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Other=2,
    }

    /// <summary>
    /// Enum tình trạng công việc
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public enum WorkStatus
    {
        /// <summary>
        /// Đã nghỉ việc
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Resign=0,

        /// <summary>
        /// Đang làm việc
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Working=1,

        /// <summary>
        /// Đang thử việc
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        TrailWork=2,

        /// <summary>
        /// Đã nghỉ hưu
        /// </summary>
        /// createdby ngochtb(01/12/2020)
        Retired=3
    }
}
