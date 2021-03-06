using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
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
        private readonly ICrudAsync<RegisterAssembleRequestDTO> con = new ServiceAssembleDTO();
        private readonly ICrudAsync<RegisterAssembleTypeRequestDTO> cont = new ServiceAssembleTypeDTO();
        private readonly IMapper _mapper;
        public AssembleController(IMapper mapper)
        {
            _mapper = mapper;
        }


        //GET: Assemble
        public async Task<IActionResult> Index()
        {
            List<Assemble> assembleList = new();
            var assembleDTOList = await con.GetEntity(nameService, serviceGetAssemble);
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
            var typeDTOList = await cont.GetEntity(nameService, serviceGetAssembleType);
            List<SelectListItem> items = typeDTOList.ConvertAll(t =>
            {
                return new SelectListItem()
                {
                    Text = t.AssembleTypeDescription.ToString(),
                    Value = t.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Assemble assemble)
        {
            if (ModelState.IsValid)
            {
                var typeDTOList = await cont.GetEntity(nameService, serviceGetAssembleType);
                List<SelectListItem> items = typeDTOList.ConvertAll(t =>
                {
                    return new SelectListItem()
                    {
                        Text = t.AssembleTypeDescription.ToString(),
                        Value = t.Id.ToString(),
                        Selected = false
                    };
                });
                ViewBag.items = items;

                foreach (var item in typeDTOList)
                {
                    if (item.Id.Equals(assemble.AssembleType.Id))
                    {
                        assemble.AssembleType.Id = item.Id;
                    }
                }
                var assembleDTO = _mapper.Map<RegisterAssembleRequestDTO>(assemble);
                var request = await con.PostCreateEntity(nameService, serviceGetAssemble, assembleDTO);
                
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
            var assemblyDTO = await con.GetUpdateEntity(nameService, serviceGetAssemble, id);
            return View(assemblyDTO);
        }
        [HttpPost]
        public async Task<IActionResult> Update(RegisterAssembleRequestDTO assembleDTO)
        {
            //var request = await con.PutUpdateEntity(nameService, serviceGet, assembleDTO);
            //if (request) return RedirectToAction("Index");
            return View();
        }
        /*
         DELETE
        */
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var request = await con.GetDeleteEntity(nameService, serviceGetAssemble, id);
            if (request) return RedirectToAction("Index");
            return View();
        }
        /*
        DETAIL
        */
        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var typeDTOList = await cont.GetEntity(nameService, serviceGetAssembleType);
            List<SelectListItem> items = typeDTOList.ConvertAll(t =>
            {
                return new SelectListItem()
                {
                    Text = t.AssembleTypeDescription.ToString(),
                    Value = t.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            if (id == null)
            {
                return NotFound();
            }
            var assembleDTO = await con.GetDetailEntity(nameService, serviceGetAssemble, id);
            var assemble = _mapper.Map<Assemble>(assembleDTO);
            return View(assemble);
        }
    }
}

