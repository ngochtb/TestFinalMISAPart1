using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.Web.Controllers
{
    public class EmployeesController : BaseEntityController<Employee>
    {
        IEmployeeService _baseService;
        public EmployeesController(IEmployeeService baseService) : base(baseService)
        {
            _baseService = baseService;   
        }

        [Route("Filter")]
        [HttpGet()]
        public IActionResult GetEmployeesFilter([FromQuery]String specs,[FromQuery]String DepartmentId, [FromQuery]String PossitionId )
        {
            var result = _baseService.GetEntityFilter(specs, DepartmentId, PossitionId);
            return Ok(result);
        }

        [Route("GetMaxEmployeeCode")]
        [HttpGet()]
        public IActionResult GetMaxEmployeeCode()
        {
            var result = _baseService.GetMaxEmployeeCode();
            return Ok(result);
        }
    }
}
