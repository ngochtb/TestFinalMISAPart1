using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface danh mục vị trí
    /// </summary>
    /// createdby ngochtb(01/12/2020)
    public interface IPossitionRepository: IBaseRepository<Possition>
    {
        /// <summary>
        /// Lấy danh sách vị trí theo mã vị trí
        /// </summary>
        /// <param name="PossitionCode"></param>
        /// <returns></returns>
        //Possition GetPossitionByCode(string PossitionCode);
    }
}
