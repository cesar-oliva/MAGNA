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
    public class NoticeCategoryController : Controller
    {
        IApplication<NoticeCategory> _noticeCategory;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Notice category and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="noticeCategory"></param>
        /// <param name="mapper"></param>
        public NoticeCategoryController(IApplication<NoticeCategory> noticeCategory, IMapper mapper)
        {
            _noticeCategory = noticeCategory;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of notice category objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterNoticeCategoryRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterNoticeCategoryRequestDTO> noticeCategoryDTO = new();
            var noticeCategory = await _noticeCategory.GetAllAsync();

            foreach (var item in noticeCategory)
            {
                noticeCategoryDTO.Add(_mapper.Map<RegisterNoticeCategoryRequestDTO>(item));
            }
            return Ok(noticeCategoryDTO);
        }
    }
}
