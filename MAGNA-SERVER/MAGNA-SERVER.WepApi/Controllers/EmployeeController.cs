using AutoMapper;
using MAGNA_SERVER.Application;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace MAGNA_SERVER.WebApi.Controllers
{
    /*Guarantees that the entire controller will ask for authorization*/
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        IApplication<Employee> _employee;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Employee and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="employee"></param>
        /// <param name="mapper"></param>
        public EmployeeController(IApplication<Employee> employee,IMapper mapper)
        {
            _employee = employee;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of employee objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterEmployeeRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterEmployeeRequestDTO> employeeDTO = new();
            var employee = await _employee.GetAllAsync();
     
            foreach (var item in employee)
            {
               employeeDTO.Add( _mapper.Map<RegisterEmployeeRequestDTO>(item));
            }

            return Ok(employeeDTO);
        }
        /// <summary>
        /// get a employee object
        /// </summary>
        /// <remarks>
        /// receives an id from the client and returns an object of type employee
        /// </remarks>
        /// <param name="id">object id</param>
        /// <returns>employee object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            if (id.Equals(Guid.Empty)) return NotFound();
            var employee = await _employee.GetByIdAsync(id);
            return Ok(_mapper.Map<RegisterEmployeeRequestDTO>(employee));
        }
        [HttpPost]
        public async Task<IActionResult> Save(RegisterEmployeeRequestDTO employeeDto) 
        {
            Employee employee = _mapper.Map<Employee>(employeeDto);
            await _employee.SaveAsync(employee);
            return Ok(employee);
        }

        /// <summary>
        /// update a employee objetc by id
        /// </summary>
        /// <remarks>
        /// Receive the object to modify, look for the employee by id, map the entities request the update
        /// </remarks>
        /// <param name="dto"></param>
        /// <returns>response object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(RegisterEmployeeRequestDTO dto)
        {
            if (dto.Id.Equals(Guid.Empty)|| dto == null) return NotFound();
            var employee = _mapper.Map<Employee>(dto);
            await _employee.UpdateAsync(employee);
            return Ok(employee);
        }

        /// <summary>
        /// Delete a employe object by id
        /// </summary>
        /// <remarks>
        ///  Receive the object to deleted, look for the employee by id, request the delete
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>response object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id.Equals(Guid.Empty)) return NotFound();
            _employee.DeleteAsync(id);
            return Ok();
        }
    }
}
