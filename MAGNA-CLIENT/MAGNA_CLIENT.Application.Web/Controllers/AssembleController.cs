using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Object;
using MAGNA_CLIENT.Application.Web.Service;
using MAGNA_CLIENT.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    public class AssembleController : Controller
    {
        const string nameService = "https://localhost:5001/";
        const string serviceGetAssemble= "api/Assemble";
        const string serviceGetAssembleType = "api/AssembleType";
        const string serviceGetTechnicalLocation = "api/TechnicalLocation";
        private readonly ICrudAsync<RegisterAssembleRequestDTO> ca = new ServiceAssemble();
        private readonly ICrudAsync<RegisterAssembleTypeRequestDTO> ct = new ServiceAssembleType();
        private readonly ICrudAsync<RegisterTechnicalLocationRequestDTO> ctl = new ServiceTechnicalLocation();
        private readonly IMapper _mapper;
        public AssembleController(IMapper mapper)
        {
            _mapper = mapper;
        }


        //GET: Assemble
        public async Task<IActionResult> Index()
        {
            List<Assemble> assembleList = new();
            var assembleDTOList = await ca.GetEntity(nameService, serviceGetAssemble);
            var assembleTypeDTOList = await ct.GetEntity(nameService, serviceGetAssembleType);
            var technicalLocationDTOList = await ctl.GetEntity(nameService, serviceGetTechnicalLocation);
            foreach (var item in assembleDTOList)
            {                
                assembleList.Add(_mapper.Map<Assemble>(item));
            }
            return View(assembleList);
        }
        /*
        CREATE
       */
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.assembleType = await GetAssembleTypeList();
            ViewBag.technicalLocation = await GetTechnicalLocationList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Assemble assemble)
        {
            if (ModelState.IsValid)
            {
                var typeDTOList = await ct.GetEntity(nameService, serviceGetAssembleType);
                ViewBag.assembleType = GetAssembleTypeList();

                foreach (var item in typeDTOList)
                {
                    if (item.Id.Equals(assemble.AssembleTypeId))
                    {
                        assemble.AssembleTypeId = item.Id;
                    }
                }
                var assembleDTO = _mapper.Map<RegisterAssembleRequestDTO>(assemble);
                var request = await ca.PostCreateEntity(nameService, serviceGetAssemble, assembleDTO);
                
                if (request)
                {
                    TempData["mensaje_create"] = "assemble created successfully";
                    return RedirectToAction("Index");
                }

            }
            TempData["mensaje_error"] = "ERROR assemble created successfully";
            return View();
        }
        /*
         UPDATE
        */
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var assembleDTO = await ca.GetDetailEntity(nameService, serviceGetAssemble, id);
            ViewBag.assembleType = await GetAssembleTypeList();
            ViewBag.technicalLocation = await GetTechnicalLocationList();
            var result = _mapper.Map<Assemble>(assembleDTO);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Assemble assemble)        
        {
            if (ModelState.IsValid)
            {
                var assembleDTO = _mapper.Map<RegisterAssembleRequestDTO>(assemble);
                var request = await ca.PutUpdateEntity(nameService, serviceGetAssemble, assembleDTO);
                if (request)
                {
                    TempData["mensaje_update"] = "assemble updated successfully";
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
            if (id == null)
            {
                return NotFound();
            }
            var assembleDTO = await ca.GetDetailEntity(nameService, serviceGetAssemble, id);
            var technicalLocationDTOList = await ctl.GetEntity(nameService, serviceGetTechnicalLocation);
            var assembleTypeDTOList = await ct.GetEntity(nameService, serviceGetAssembleType);
            foreach (var item in assembleTypeDTOList)
            {
                if (item.Id.Equals(assembleDTO.AssembleTypeId))
                    ViewBag.assembleType = item.AssembleTypeDescription;
            }
            foreach (var item in technicalLocationDTOList)
            {
                if (item.Id.Equals(assembleDTO.TechnicalLocationId))
                    ViewBag.technicalLocation = item.TechnicalLocationDescription;
            }
            var assemble = _mapper.Map<Assemble>(assembleDTO);
            return View(assemble);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Assemble assemble)
        {
            if (ModelState.IsValid)
            {
                var request = await ca.GetDeleteEntity(nameService, serviceGetAssemble, assemble.Id);
                TempData["mensaje_delete"] = "assemble deleted successfully";
                if (request) return RedirectToAction("Index");
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
            if (id == null)
            {
                return NotFound();
            }
            var assembleDTO = await ca.GetDetailEntity(nameService, serviceGetAssemble, id);
            var technicalLocationDTOList = await ctl.GetEntity(nameService, serviceGetTechnicalLocation);
            var assembleTypeDTOList = await ct.GetEntity(nameService, serviceGetAssembleType);
            foreach (var item in assembleTypeDTOList)
            {
                if (item.Id.Equals(assembleDTO.AssembleTypeId))
                    ViewBag.assembleType = item.AssembleTypeDescription;
            }
            foreach (var item in technicalLocationDTOList)
            {
                if (item.Id.Equals(assembleDTO.TechnicalLocationId))
                    ViewBag.technicalLocation = item.TechnicalLocationDescription;
            }
            var assemble = _mapper.Map<Assemble>(assembleDTO);
            return View(assemble);
        }

        [HttpPost]
        public async Task<IActionResult> Detail(Employee employee)
        {
            return RedirectToAction("Index");
        }


        public async Task<List<SelectListItem>> GetAssembleTypeList()
        {
            var assembleTypeDTOList = await ct.GetEntity(nameService, serviceGetAssembleType);
            List<SelectListItem> items = assembleTypeDTOList.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.AssembleTypeDescription.ToString(),
                    Value = g.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetTechnicalLocationList()
        {
            var technicalLocationDTOList = await ctl.GetEntity(nameService, serviceGetTechnicalLocation);
            List<SelectListItem> items = technicalLocationDTOList.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.TechnicalLocationDescription.ToString(),
                    Value = g.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
    }
}

