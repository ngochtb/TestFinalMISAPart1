using MISA.ApplicationCore.Interfaces;
using System;
using MISA.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Web.Controllers
{
   
    public class PossitionsController : BaseEntityController<Possition>
    {
        IBaseService<Possition> _baseService;
        public PossitionsController(IBaseService<Possition> baseService) : base(baseService)
        {
            _baseService = baseService;
        }
    }
}
