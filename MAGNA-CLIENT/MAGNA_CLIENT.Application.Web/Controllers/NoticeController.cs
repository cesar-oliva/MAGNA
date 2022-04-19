using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Application.Web.Service;
using MAGNA_CLIENT.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    public class NoticeController : Controller
    {
        const string nameService = "https://localhost:5001/";
        const string serviceGetEmployee = "api/Notice";
        private readonly ICrudAsync<RegisterNoticeRequestDTO> con = new ServiceNoticeDTO();

        private readonly IMapper _mapper;
        public NoticeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
