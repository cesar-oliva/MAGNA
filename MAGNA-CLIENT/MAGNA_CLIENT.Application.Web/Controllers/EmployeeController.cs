using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Application.Web.Service;
using AutoMapper;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    public class EmployeeController : Controller
    {
        const string nameService = "https://localhost:5001/";
        const string serviceGetEmployee = "api/Employee";
        const string serviceGetGender = "api/Gender";
        private readonly ICrudAsync<RegisterEmployeeRequestDTO> con = new ServiceEmployeeDTO();
        private readonly ICrudAsync<QueryGenderRequestDTO> cong = new ServiceGender();
        private readonly IMapper _mapper;
        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        //GET: Assemble
        public async Task<IActionResult> Index()
        {
            List<Employee> employeeList = new();
            var employeeDTOList = await con.GetEntity(nameService, serviceGetEmployee);
            foreach (var item in employeeDTOList)
            {
                employeeList.Add(_mapper.Map<Employee>(item));
            }            
            return View(employeeList);
        }

        /*
        CREATE
       */
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
            List<SelectListItem> items = genderDTOList.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.GenderDescription.ToString(),
                    Value = g.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]IFormFile file,Employee employee)
        {
            if (ModelState.IsValid)
            {
                var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
                List<SelectListItem> items = genderDTOList.ConvertAll(g =>
                {
                    return new SelectListItem()
                    {
                        Text = g.GenderDescription.ToString(),
                        Value = g.Id.ToString(),
                        Selected = false
                    };
                });
                ViewBag.items = items;
                foreach (var item in genderDTOList)
                {
                    if (item.Id.Equals(employee.Gender.Id))
                    {
                        employee.Gender.GenderDescription = item.GenderDescription;
                        employee.Gender.GenderState = item.GenderState;
                    }
                }
                //string folder = "~/employee/profilepicture/";
                //if (employee.EmployeePhotoUrl != null)
                //{
                //    folder += Guid.NewGuid().ToString() + "_" + file.FileName;
                //    string server = Path.Combine(folder);
                //}
                var employeeDTO = _mapper.Map<RegisterEmployeeRequestDTO>(employee);
                //employeeDTO.EmployeePhotoUrl = folder;
                var request = await con.PostCreateEntity(nameService, serviceGetEmployee, employeeDTO);
                TempData["mensaje_create"] = "employee created successfully";
                if (request) return RedirectToAction("Index");
            }
            return View();
        }
        /*
         UPDATE
        */
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var employee = await con.GetDetailEntity(nameService, serviceGetEmployee, id);
            var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
            List<SelectListItem> items = genderDTOList.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.GenderDescription.ToString(),
                    Value = g.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            var employeeDTO = await con.GetUpdateEntity(nameService, serviceGetEmployee, id);
            var result = _mapper.Map<Employee>(employeeDTO);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] IFormFile file,Employee employee)
        {
            if (ModelState.IsValid)
            {
                var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
                List<SelectListItem> items = genderDTOList.ConvertAll(g =>
                {
                    return new SelectListItem()
                    {
                        Text = g.GenderDescription.ToString(),
                        Value = g.Id.ToString(),
                        Selected = false
                    };
                });
                ViewBag.items = items;
                foreach (var item in genderDTOList)
                {
                    if (item.Id.Equals(employee.Gender.Id))
                    {
                        employee.Gender.GenderDescription = item.GenderDescription;
                        employee.Gender.GenderState = item.GenderState;
                    }
                }
                //string folder = "~/employee/profilepicture/";
                //if (employee.EmployeePhotoUrl != null)
                //{
                //    folder += Guid.NewGuid().ToString() + "_" + file.FileName;
                //    string server = Path.Combine(folder);
                //}
                var employeeDTO = _mapper.Map<RegisterEmployeeRequestDTO>(employee);
                // employeeDTO.EmployeePhotoUrl = folder;
                var request = await con.PutUpdateEntity(nameService, serviceGetEmployee, employeeDTO);
                
                if (request)
                {
                    TempData["mensaje_update"] = "employee updated successfully";
                    return RedirectToAction("Index");
                }
                    
            }
            TempData["mensaje_delete"] = "an error occurred during the operation";
            return RedirectToAction("Index");
        }
        /*
         DELETE
        */
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null || id.Equals(Guid.Empty))
            {
                return NotFound();
            }
            var employee = await con.GetDetailEntity(nameService, serviceGetEmployee, id);
            var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
            List<SelectListItem> items = genderDTOList.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.GenderDescription.ToString(),
                    Value = g.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            var employeeDTO = await con.GetUpdateEntity(nameService, serviceGetEmployee,id);
            var result = _mapper.Map<Employee>(employeeDTO);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
                List<SelectListItem> items = genderDTOList.ConvertAll(g =>
                {
                    return new SelectListItem()
                    {
                        Text = g.GenderDescription.ToString(),
                        Value = g.Id.ToString(),
                        Selected = false
                    };
                });
                ViewBag.items = items;
              
                if (ModelState.IsValid)
                {
                    var request = await con.GetDeleteEntity(nameService, serviceGetEmployee, employee.Id);
                    TempData["mensaje_delete"] = "employee deleted successfully";
                    if (request) return RedirectToAction("Index");
                }
                return View();

            }
            TempData["mensaje_delete"] = "an error occurred during the operation";
            return RedirectToAction("Index");
        }
        /*
        DETAIL
        */
        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var genderDTOList = await cong.GetEntity(nameService, serviceGetGender);
            List<SelectListItem> items = genderDTOList.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.GenderDescription.ToString(),
                    Value = g.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            if (id == null)
            {
                return NotFound();
            }
            var employeeDTO = await con.GetDetailEntity(nameService, serviceGetEmployee, id);
            var employee = _mapper.Map<Employee>(employeeDTO);
            return View(employee);
        }
    }
}
