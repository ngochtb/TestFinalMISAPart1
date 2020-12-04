using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    public class PossitionService : BaseService<Possition>, IPossitionService
    {
        IPossitionRepository _PossitionRepository;
        public PossitionService(IPossitionRepository PossitionRepository) : base(PossitionRepository)
        {
            _PossitionRepository = PossitionRepository;
        }
    }
}
