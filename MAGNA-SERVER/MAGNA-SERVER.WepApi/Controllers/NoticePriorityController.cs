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
    public class NoticePriorityController : Controller
    {
        IApplication<NoticePriority> _noticePriority;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Notice Priority and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="noticePriority"></param>
        /// <param name="mapper"></param>
        public NoticePriorityController(IApplication<NoticePriority> noticePriority, IMapper mapper)
        {
            _noticePriority = noticePriority;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of notice priority objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterNoticePriorityRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterNoticePriorityRequestDTO> noticePriorityDTO = new();
            var noticePriority = await _noticePriority.GetAllAsync();

            foreach (var item in noticePriority)
            {
                noticePriorityDTO.Add(_mapper.Map<RegisterNoticePriorityRequestDTO>(item));
            }
            return Ok(noticePriorityDTO);
        }
    }
}
