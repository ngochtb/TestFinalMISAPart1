using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class BaseEntityController<TEntity> : ControllerBase
    {
        IBaseService<TEntity> _baseService;
        public BaseEntityController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// Lấy danh sách bản ghi
        /// </summary>
        /// <returns>Danh sách bản ghi</returns>
        /// createdby ngochtb(01/12/2020)
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.GetEntities();
            return Ok(entities);
        }

        /// <summary>
        /// Lấy danh sách bản ghi theo id và tên
        /// </summary>
        /// <param name="id">id của bản ghi</param>
        /// <param name="name">tên của bản ghi</param>
        /// <returns>Danh sách bản ghi</returns>
        /// createdby ngochtb(01/12/2020)
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var entity = _baseService.GetEntityById(Guid.Parse(id));
            return Ok(entity);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post(TEntity entity)
        {
            var serviceResult = _baseService.Add(entity);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.NotValid)
                return BadRequest(serviceResult);
            else
                return Ok(serviceResult);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] string id, [FromBody] TEntity entity)
        {
            var keyProperty = entity.GetType().GetProperty($"{typeof(TEntity).Name}Id");
            if (keyProperty.PropertyType == typeof(Guid))
            {
                keyProperty.SetValue(entity, Guid.Parse(id));
            }
            else if (keyProperty.PropertyType == typeof(int))
            {
                keyProperty.SetValue(entity, int.Parse(id));
            }
            else
            {
                keyProperty.SetValue(entity, id);
            }

            var serviceResult = _baseService.Update(entity);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.NotValid)
                return BadRequest(serviceResult);
            else
                return Ok(serviceResult);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var res = _baseService.Delete(id);
            return Ok(res);
        }
    }
}
