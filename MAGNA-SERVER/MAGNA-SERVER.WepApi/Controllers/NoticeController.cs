using AutoMapper;
using MAGNA_SERVER.Application;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace MAGNA_SERVER.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticeController : Controller
    {
        IApplication<Notice> _notice;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Notice and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="notice"></param>
        /// <param name="mapper"></param>
        public NoticeController(IApplication<Notice> notice, IMapper mapper)
        {
            _notice = notice;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of notice objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterNoticeRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterNoticeRequestDTO> noticeDTO = new();
            var notice = await _notice.GetAllAsync();

            foreach (var item in notice)
            {
                noticeDTO.Add(_mapper.Map<RegisterNoticeRequestDTO>(item));
            }
            return Ok(noticeDTO);
        }
        /// <summary>
        /// get a notice object
        /// </summary>
        /// <remarks>
        /// receives an id from the client and returns an object of type notice
        /// </remarks>
        /// <param name="id">object id</param>
        /// <returns>notice object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            if (id.Equals(Guid.Empty)) return NotFound();
            var notice = await _notice.GetByIdAsync(id);
            return Ok(_mapper.Map<RegisterNoticeRequestDTO>(notice));
        }
        [HttpPost]
        public async Task<IActionResult> Save(RegisterNoticeRequestDTO noticeDto)
        {
            var notice = _mapper.Map<Notice>(noticeDto);
            notice.Id = new Guid();
            await _notice.SaveAsync(notice);
            return Ok(notice);
        }
        /// <summary>
        /// update a notice objetc by id
        /// </summary>
        /// <remarks>
        /// Receive the object to modify, look for the notice by id, map the entities request the update
        /// </remarks>
        /// <param name="dto"></param>
        /// <returns>response object</returns>
        /// <response code="200"> OK. returns the requested object </response>
        /// <response code="400"> NotFound. returns the requested object was not found </response>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(RegisterNoticeRequestDTO dto)
        {
            if (dto.Id.Equals(Guid.Empty) || dto == null) return NotFound();
            var notice = _mapper.Map<Notice>(dto);
            await _notice.UpdateAsync(notice);
            return Ok(notice);
        }

        /// <summary>
        /// Delete a notice object by id
        /// </summary>
        /// <remarks>
        ///  Receive the object to deleted, look for the notice by id, request the delete
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
            _notice.DeleteAsync(id);
            return Ok();
        }
    }
}
