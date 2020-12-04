using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infarstructure
{
    public class PossitionRepository:BaseRepository<Possition>, IPossitionRepository
    {
        #region DECLARE
        #endregion

        public PossitionRepository(IConfiguration configuration) : base(configuration)
        {

        }

        //public override IEnumerable<Possition> GetEntities()
        //{
        //    return base.GetEntities("Proc_Possitions");
        //}
    }
}
