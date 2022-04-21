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
    public class NoticeTypeController : Controller
    {
        IApplication<NoticeType> _noticeType;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Notice Type and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="noticeType"></param>
        /// <param name="mapper"></param>
        public NoticeTypeController(IApplication<NoticeType> noticeType, IMapper mapper)
        {
            _noticeType = noticeType;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of notice type objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterNoticeTypeRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterNoticeTypeRequestDTO> noticeTypeDTO = new();
            var noticeType = await _noticeType.GetAllAsync();

            foreach (var item in noticeType)
            {
                noticeTypeDTO.Add(_mapper.Map<RegisterNoticeTypeRequestDTO>(item));
            }
            return Ok(noticeTypeDTO);
        }
    }
}
