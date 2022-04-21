using AutoMapper;
using MAGNA_SERVER.Application;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace MAGNA_SERVER.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticeStateController : Controller
    {
        IApplication<NoticeState> _noticeState;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Notice State and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="noticeState"></param>
        /// <param name="mapper"></param>
        public NoticeStateController(IApplication<NoticeState> noticeState, IMapper mapper)
        {
            _noticeState = noticeState;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of notice state objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterNoticeStateRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterNoticeStateRequestDTO> noticeStateDTO = new();
            var noticeState = await _noticeState.GetAllAsync();

            foreach (var item in noticeState)
            {
                noticeStateDTO.Add(_mapper.Map<RegisterNoticeStateRequestDTO>(item));
            }
            return Ok(noticeStateDTO);
        }
    }
}
