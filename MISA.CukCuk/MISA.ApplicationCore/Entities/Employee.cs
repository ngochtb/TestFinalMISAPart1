using MISA.ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Thông tin nhân viên
    /// </summary>
    /// Createdby ngochtb (30/11/2020)
    public class Employee:BaseEntity
    {

        /// <summary>
        /// Khóa chính
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Tên đầu
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string FirstName { get; set; }
        /// <summary>
        /// Tên cuối
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string LastName { get; set; }
        /// <summary>
        /// Tên đầy đủ
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string  FullName { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string Email { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public Enums.Gender? Gender { get; set; }
        /// <summary>
        /// Định nghĩa giới tính
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string GenderName
        {
            get
            {
                var name = string.Empty;
                switch (Gender)
                {
                    case Enums.Gender.Female:
                        name = Properties.Resources.Enum_Gender_Female;
                        break;
                    case Enums.Gender.Male:
                        name = Properties.Resources.Enum_Gender_Male;
                        break;
                    case Enums.Gender.Other:
                        name = Properties.Resources.Enum_Gender_Other;
                        break;
                    default:
                        break;
                }
                return name;
            }
        }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string Address { get; set; }
        /// <summary>
        /// Tên vị trí
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string PossitionName { get; set; }
        /// <summary>
        /// Id vị trí
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public Guid PossitionId { get; set; }
        /// <summary>
        /// Tên phòng ban
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string DepartmentName { get; set; }
        /// <summary>
        /// Id phòng ban
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Lương
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public double? Salary { get; set; }
        /// <summary>
        /// Số chứng minh thư nhân dân
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public string IdentityNumber { get; set; }
        /// <summary>
        /// Ngày cấp
        /// </summary>
        ///  createdby ngochtb(02/12/2020)
        public DateTime? IdentityDate { get; set; }
        /// <summary>
        /// Nơi cấp
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public string IdentityPlace { get; set; }
        /// <summary>
        /// Mã số thuế
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public string PersonalTaxCode { get; set; }
        /// <summary>
        /// Ngày gia nhập
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public DateTime? JoinDate { get; set; }
        /// <summary>
        /// Tình trạng công việc
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public WorkStatus? WorkStatus { get; set; }
        /// <summary>
        /// Định nghĩa tình trạng công việc
        /// </summary>
        /// createdby ngochtb(02/12/2020)
        public string WorkStatusName
        {
            get
            {
                var name = string.Empty;
                switch (WorkStatus)
                {
                    case Enums.WorkStatus.Resign:
                        name = Properties.Resources.Enum_WorkStatus_Resign;
                        break;
                    case Enums.WorkStatus.Working:
                        name = Properties.Resources.Enum_WorkStatus_Working;
                        break;
                    case Enums.WorkStatus.TrailWork:
                        name = Properties.Resources.Enum_WorkStatus_TrailWork;
                        break;
                    case Enums.WorkStatus.Retired:
                        name = Properties.Resources.Enum_WorkStatus_Retired;
                        break;
                    default:
                        break;
                }
                return name;
            }
        }
    }
}
