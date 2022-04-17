using AutoMapper;
using MAGNA_SERVER.Application;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace MAGNA_SERVER.WebApi.Controllers
{
    /*Guarantees that the entire controller will ask for authorization*/
   // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class AssembleTypeController : Controller
    {
        IApplication<AssembleType> _assembleType;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in AssembleType and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="assembleType"></param>
        /// <param name="mapper"></param>
        public AssembleTypeController(IApplication<AssembleType> assembleType, IMapper mapper)
        {
            _assembleType = assembleType;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of assembleType objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterAssembleTypeRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterAssembleTypeRequestDTO> assembleTypeDTO = new();
            var assembleType = await _assembleType.GetAllAsync();

            foreach (var item in assembleType)
            {
                assembleTypeDTO.Add(_mapper.Map<RegisterAssembleTypeRequestDTO>(item));
            }

            return Ok(assembleTypeDTO);
        }
        /// <summary>
        /// get a assembleType object
        /// </summary>
        /// <remarks>
        /// receives an id from the client and returns an object of type assembleType
        /// </remarks>
        /// <param name="id">object id</param>
        /// <returns>assembleType object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            if (id.Equals(Guid.Empty)) return NotFound();
            var assembleType = await _assembleType.GetByIdAsync(id);
            return Ok(_mapper.Map<RegisterAssembleTypeRequestDTO>(assembleType));
        }
        [HttpPost]
        public async Task<IActionResult> Save(RegisterAssembleTypeRequestDTO assembleTypeDto)
        {
            AssembleType assembleType = _mapper.Map<AssembleType>(assembleTypeDto);
            assembleType.Id = new Guid();
            await _assembleType.SaveAsync(assembleType);
            return Ok(assembleType);
        }

        /// <summary>
        /// update a assembleType objetc by id
        /// </summary>
        /// <remarks>
        /// Receive the object to modify, look for the assembleType by id, map the entities request the update
        /// </remarks>
        /// <param name="dto"></param>
        /// <returns>response object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(RegisterAssembleTypeRequestDTO dto)
        {
            if (dto.Id.Equals(Guid.Empty) || dto == null) return NotFound();
            var assembleType = _mapper.Map<AssembleType>(dto);
            await _assembleType.UpdateAsync(assembleType);
            return Ok(assembleType);
        }

        /// <summary>
        /// Delete a assembleType object by id
        /// </summary>
        /// <remarks>
        ///  Receive the object to deleted, look for the assembleType by id, request the delete
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
            _assembleType.DeleteAsync(id);
            return Ok();
        }
    }
}
