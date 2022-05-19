using AutoMapper;
using MAGNA_SERVER.Application;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace MAGNA_SERVER.WebApi.Controllers
{
    /*Guarantees that the entire controller will ask for authorization*/
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class AssembleController : ControllerBase
    {
        IApplication<Assemble> _assemble;
        IApplication<AssembleType> _assembleType;

        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Assemble and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="assemble"></param>
        /// <param name="mapper"></param>
        public AssembleController(IApplication<Assemble> assemble, IApplication<AssembleType> assembleType, IMapper mapper)
        {
            _assemble = assemble;
            _assembleType = assembleType;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of assemble objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterAssembleRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterAssembleRequestDTO> assembleDTO = new();
            var assemble = await _assemble.GetAllAsync();
            var assembleType = await _assembleType.GetAllAsync();
            foreach (var item in assemble)
            {
                assembleDTO.Add(_mapper.Map<RegisterAssembleRequestDTO>(item));
            }
            return Ok(assembleDTO);
        }
        /// <summary>
        /// get a assemble object
        /// </summary>
        /// <remarks>
        /// receives an id from the client and returns an object of type assemble
        /// </remarks>
        /// <param name="id">object id</param>
        /// <returns>assemble object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            if (id.Equals(Guid.Empty)) return NotFound();
            var assemble = await _assemble.GetByIdAsync(id);
            return Ok(_mapper.Map<RegisterAssembleRequestDTO>(assemble));
        }
        [HttpPost]
        public async Task<IActionResult> Save(RegisterAssembleRequestDTO assembleDto)
        {
            Assemble assemble = _mapper.Map<Assemble>(assembleDto);
            //assemble.Id = new Guid();
            await _assemble.SaveAsync(assemble);
            return Ok(assemble);
        }

        /// <summary>
        /// update a assemble objetc by id
        /// </summary>
        /// <remarks>
        /// Receive the object to modify, look for the assemble by id, map the entities request the update
        /// </remarks>
        /// <param name="dto"></param>
        /// <returns>response object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(RegisterAssembleRequestDTO dto)
        {
            if (dto.Id.Equals(Guid.Empty) || dto == null) return NotFound();
            var assemble = _mapper.Map<Assemble>(dto);
            await _assemble.UpdateAsync(assemble);
            return Ok(assemble);
        }

        /// <summary>
        /// Delete a assemble object by id
        /// </summary>
        /// <remarks>
        ///  Receive the object to deleted, look for the assemble by id, request the delete
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
            _assemble.DeleteAsync(id);
            return Ok();
        }

    }
}
