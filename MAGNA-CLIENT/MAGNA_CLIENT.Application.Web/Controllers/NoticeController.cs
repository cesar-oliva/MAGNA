using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Application.Web.Service;
using MAGNA_CLIENT.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        /*
        CREATE
       */
        //[HttpGet]
        //public async Task<IActionResult> Create()
        //{
        //    var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
        //    List<SelectListItem> items = genderDTOList.ConvertAll(g =>
        //    {
        //        return new SelectListItem()
        //        {
        //            Text = g.GenderDescription.ToString(),
        //            Value = g.Id.ToString(),
        //            Selected = false
        //        };
        //    });
        //    ViewBag.items = items;
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create([FromForm] IFormFile file, Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
               
        //        ViewBag.items = items;
        //        //foreach (var item in genderDTOList)
        //        //{
        //        //    if (item.Id.Equals(employee.Gender.Id))
        //        //    {
        //        //        employee.Gender.GenderDescription = item.GenderDescription;
        //        //        employee.Gender.GenderState = item.GenderState;
        //        //    }
        //        //}
        //        //string folder = "~/employee/profilepicture/";
        //        //if (employee.EmployeePhotoUrl != null)
        //        //{
        //        //    folder += Guid.NewGuid().ToString() + "_" + file.FileName;
        //        //    string server = Path.Combine(folder);
        //        //}
        //        var employeeDTO = _mapper.Map<RegisterEmployeeRequestDTO>(employee);
        //        //employeeDTO.EmployeePhotoUrl = folder;
        //        var request = await con.PostCreateEntity(nameService, serviceGetEmployee, employeeDTO);
        //        TempData["mensaje_create"] = "employee created successfully";
        //        if (request) return RedirectToAction("Index");
        //    }
        //    return View();
        //}

    }
}
