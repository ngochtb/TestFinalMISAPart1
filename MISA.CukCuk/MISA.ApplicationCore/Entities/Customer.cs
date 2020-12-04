using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Khách hàng
    /// </summary>
    /// CreatedBy: HTBNgoc (23/11/2020)
    public class Customer:BaseEntity
    {
        #region Declare

        #endregion

        #region Constructor
        public Customer()
        {

        }
        #endregion

        #region Property
        /// <summary>
        /// Khóa chính
        /// </summary>
        [PrimaryKey]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        [Required]
        [DisplayName("Mã khách hàng")]
        [MaxLength(20,"Mã khách hàng đã vượt quá 20 ký tự cho phép")]
        public string CustomerCode { get; set; }

        /// <summary>
        /// Họ và đệm
        /// </summary>
        [DisplayName("Họ và đệm")]
        public string FirstName { get; set; }

        /// <summary>
        /// Tên
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Họ và tên
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Giới tính (0-Nữ, 1- Nam, 2- Khác...)
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ngày tháng năm sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Địa chỉ Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///  Số điện thoại
        /// </summary>
        /// 
        [CheckDuplicate]
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Nhóm khách hàng
        /// </summary>
        public Guid? CustomerGroupId { get; set; }

        /// <summary>
        /// Số tiền còn nợ
        /// </summary>
        public double? DebitAmount { get; set; }

        /// <summary>
        ///  Số thẻ thành viên
        /// </summary>
        public string MemberCardCode { get; set; }

        /// <summary>
        /// Tên công ty làm việc
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Mã số thuế của công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }

        /// <summary>
        /// Ngừng theo dõi (true- ngừng theo dõi)
        /// </summary>
        public bool? IsStopFollow { get; set; }
        #endregion

        #region Method

        #endregion
    }
}
