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
    public class TechnicalLocationController : Controller
    {
        IApplication<TechnicalLocation> _technicallLocation;
        private readonly IMapper _mapper;
        /// <summary>
        /// receives by parameter the application in Techinical Location and we inject it
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="technicalLocation"></param>
        /// <param name="mapper"></param>
        public TechnicalLocationController(IApplication<TechnicalLocation> technicalLocation, IMapper mapper)
        {
            _technicallLocation = technicalLocation;
            _mapper = mapper;
        }
        /// <summary>
        /// get a list of technical Lcoation objects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(RegisterTechnicalLocationRequestDTO))]
        public async Task<IActionResult> Get()
        {
            List<RegisterTechnicalLocationRequestDTO> technicalLocationDTO = new();
            var technicalLocation = await _technicallLocation.GetAllAsync();

            foreach (var item in technicalLocation)
            {
                technicalLocationDTO.Add(_mapper.Map<RegisterTechnicalLocationRequestDTO>(item));
            }
            return Ok(technicalLocationDTO);
        }
    }
}
