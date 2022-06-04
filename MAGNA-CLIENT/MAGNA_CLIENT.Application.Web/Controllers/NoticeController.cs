using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Notice;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Object;
using MAGNA_CLIENT.Application.Web.Service;
using MAGNA_CLIENT.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    public class NoticeController : Controller
    {
        const string nameService = "https://localhost:5001/";
        const string serviceGetNotice = "api/Notice";
        const string serviceGetNoticePriority = "api/NoticePriority";
        const string serviceGetNoticeCategory = "api/NoticeCategory";
        const string serviceGetEmployee = "api/Employee";
        const string serviceGetAssemble = "api/Assemble";
        const string serviceGetNoticeState = "api/NoticeState";
        const string serviceGetNoticeType = "api/NoticeType";
        const string serviceGetTechnicalLocation = "api/TechnicalLocation";

        private readonly ICrudAsync<RegisterNoticeRequestDTO> sn = new ServiceNotice();
        private readonly ICrudAsync<RegisterNoticePriorityRequestDTO> np = new ServiceNoticePriority();
        private readonly ICrudAsync<RegisterNoticeCategoryRequestDTO> nc = new ServiceNoticeCategory();
        private readonly ICrudAsync<RegisterEmployeeRequestDTO> se = new ServiceEmployee();
        private readonly ICrudAsync<RegisterAssembleRequestDTO> sa = new ServiceAssemble();
        private readonly ICrudAsync<RegisterNoticeStateRequestDTO> ss = new ServiceNoticeState();
        private readonly ICrudAsync<RegisterNoticeTypeRequestDTO> nt = new ServiceNoticeType();
        private readonly ICrudAsync<RegisterTechnicalLocationRequestDTO> tl = new ServiceTechnicalLocation();

        private readonly IMapper _mapper;
        public NoticeController(IMapper mapper)
        {
            _mapper = mapper;
        }
        //GET: Assemble
        public async Task<IActionResult> Index()
        {
            TempData.Clear();
            List<Notice> noticeList = new();
            var noticeDTOList = await sn.GetEntity(nameService, serviceGetNotice);
            foreach (var item in noticeDTOList)
            {
                noticeList.Add(_mapper.Map<Notice>(item));
            }
            return View(noticeList);
        }

        /*
        CREATE
       */
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            
            ViewBag.noticePriority = await GetNoticePriorityList();
            ViewBag.noticeCategory = await GetNoticeCategoryList();
            ViewBag.noticeState = await GetNoticeStateList();
            ViewBag.employee = await GetEmployeeList();
            ViewBag.assemble = await GetAssembleList();
            ViewBag.noticeType = await GetNoticeTypeList();
            ViewBag.technicalLocation = await GetTechnicalLocationList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Notice notice)
        {
            ViewBag.noticePriority = await GetNoticePriorityList();
            ViewBag.noticeCategory = await GetNoticeCategoryList();
            ViewBag.noticeState = await GetNoticeStateList();
            ViewBag.employee = await GetEmployeeList();
            ViewBag.assemble = await GetAssembleList();
            ViewBag.noticeType = await GetNoticeTypeList();
            ViewBag.technicalLocation = await GetTechnicalLocationList();
            notice.Id = Guid.NewGuid();

            if (ModelState.IsValid)
            {               
                var noticeDTO = _mapper.Map<RegisterNoticeRequestDTO>(notice);
                var request = await sn.PostCreateEntity(nameService, serviceGetNotice, noticeDTO);
                TempData["mensaje_create"] = "notice created successfully";
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
            var noticeDTO = await sn.GetDetailEntity(nameService, serviceGetNotice, id);
            ViewBag.noticePriority = await GetNoticePriorityList();
            ViewBag.noticeCategory = await GetNoticeCategoryList();
            ViewBag.noticeState = await GetNoticeStateList();
            ViewBag.employee = await GetEmployeeList();
            ViewBag.assemble = await GetAssembleList();
            ViewBag.noticeType = await GetNoticeTypeList();
            ViewBag.technicalLocation = await GetTechnicalLocationList();
            var result = _mapper.Map<Notice>(noticeDTO);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Notice notice)
        {
            if (ModelState.IsValid)
            {
                var noticeDTO = _mapper.Map<RegisterNoticeRequestDTO>(notice);
                var request = await sn.PutUpdateEntity(nameService, serviceGetNotice, noticeDTO);
                if (request)
                {
                    TempData["mensaje_update"] = "notice updated successfully";
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
            var noticePriorityList = await np.GetEntity(nameService, serviceGetNoticePriority);
            var noticeCategoryList = await nc.GetEntity(nameService, serviceGetNoticeCategory);
            var noticeStateList = await ss.GetEntity(nameService, serviceGetNoticeState);
            var employeeList = await se.GetEntity(nameService, serviceGetEmployee);
            var assembleList = await sa.GetEntity(nameService, serviceGetAssemble);
            var noticeTypeList = await nt.GetEntity(nameService, serviceGetNoticeType);
            var technicalLocationList = await tl.GetEntity(nameService, serviceGetTechnicalLocation);

            var noticeDTO = await sn.GetDetailEntity(nameService, serviceGetNotice, id);

            foreach (var item in noticePriorityList)
            {
                if (item.Id.Equals(noticeDTO.NoticePriorityId))
                    ViewBag.noticePriority = item.NoticePriorityDescription;
            }
            foreach (var item in noticeCategoryList)
            {
                if (item.Id.Equals(noticeDTO.NoticeCategoryId))
                    ViewBag.noticeCategory = item.NoticeCategoryDescription;
            }
            foreach (var item in noticeStateList)
            {
                if (item.Id.Equals(noticeDTO.NoticeStateId))
                    ViewBag.noticeState = item.NoticeStateDescription;
            }
            foreach (var item in employeeList)
            {
                if (item.Id.Equals(noticeDTO.EmployeeId))
                    ViewBag.employee = item.EmployeeFirstName+" "+item.EmployeeLastName;
            }
            foreach (var item in assembleList)
            {
                if (item.Id.Equals(noticeDTO.AssembleId))
                    ViewBag.assemble = item.AssembleDescription;
            }
            foreach (var item in noticeTypeList)
            {
                if (item.Id.Equals(noticeDTO.NoticeTypeId))
                    ViewBag.noticeType = item.NoticeTypeDescription;
            }
            foreach (var item in technicalLocationList)
            {
                if (item.Id.Equals(noticeDTO.TechnicalLocationId))
                    ViewBag.technicalLocation = item.TechnicalLocationDescription;
            }
            var notice = _mapper.Map<Notice>(noticeDTO);
            return View(notice);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Notice notice)
        {
            if (ModelState.IsValid)
            {
                var request = await sn.GetDeleteEntity(nameService, serviceGetNotice, notice.Id);
                TempData["mensaje_delete"] = "notice deleted successfully";
                if (request) return RedirectToAction("Index");
                return View();
            }
            TempData["mensaje_delete"] = "an error occurred during the operation";
            return RedirectToAction("Index");
        }
        ///*
        //DETAIL
        //*/
        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var noticePriorityList = await np.GetEntity(nameService, serviceGetNoticePriority);
            var noticeCategoryList = await nc.GetEntity(nameService, serviceGetNoticeCategory);
            var noticeStateList = await ss.GetEntity(nameService, serviceGetNoticeState);
            var employeeList = await se.GetEntity(nameService, serviceGetEmployee);
            var assembleList = await sa.GetEntity(nameService, serviceGetAssemble);
            var noticeTypeList = await nt.GetEntity(nameService, serviceGetNoticeType);
            var technicalLocationList = await tl.GetEntity(nameService, serviceGetTechnicalLocation);

            var noticeDTO = await sn.GetDetailEntity(nameService, serviceGetNotice, id);

            foreach (var item in noticePriorityList)
            {
                if (item.Id.Equals(noticeDTO.NoticePriorityId))
                    ViewBag.noticePriority = item.NoticePriorityDescription;
            }
            foreach (var item in noticeCategoryList)
            {
                if (item.Id.Equals(noticeDTO.NoticeCategoryId))
                    ViewBag.noticeCategory = item.NoticeCategoryDescription;
            }
            foreach (var item in noticeStateList)
            {
                if (item.Id.Equals(noticeDTO.NoticeStateId))
                    ViewBag.noticeState = item.NoticeStateDescription;
            }
            foreach (var item in employeeList)
            {
                if (item.Id.Equals(noticeDTO.EmployeeId))
                    ViewBag.employee = item.EmployeeFirstName + " " + item.EmployeeLastName;
            }
            foreach (var item in assembleList)
            {
                if (item.Id.Equals(noticeDTO.AssembleId))
                    ViewBag.assemble = item.AssembleDescription;
            }
            foreach (var item in noticeTypeList)
            {
                if (item.Id.Equals(noticeDTO.NoticeTypeId))
                    ViewBag.noticeType = item.NoticeTypeDescription;
            }
            foreach (var item in technicalLocationList)
            {
                if (item.Id.Equals(noticeDTO.TechnicalLocationId))
                    ViewBag.technicalLocation = item.TechnicalLocationDescription;
            }
            var notice = _mapper.Map<Notice>(noticeDTO);
            return View(notice);
        }
        [HttpPost]
        public async Task<IActionResult> Detail(Notice notice)
        {
            return RedirectToAction("Index");
        }

        public async Task<List<SelectListItem>> GetNoticePriorityList()
        {
            var noticePriorityDTOList = await np.GetEntity(nameService, serviceGetNoticePriority);
            List<SelectListItem> items = noticePriorityDTOList.ConvertAll(np =>
            {
                return new SelectListItem()
                {
                    Text = np.NoticePriorityDescription.ToString(),
                    Value = np.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetNoticeCategoryList()
        {
            var noticeCategoryDTOList = await nc.GetEntity(nameService, serviceGetNoticeCategory);
            List<SelectListItem> items = noticeCategoryDTOList.ConvertAll(nc =>
            {
                return new SelectListItem()
                {
                    Text = nc.NoticeCategoryDescription.ToString(),
                    Value = nc.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetEmployeeList()
        {
            var employeeDTOList = await se.GetEntity(nameService, serviceGetEmployee);
            List<SelectListItem> items = employeeDTOList.ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Text = e.EmployeeFirstName.ToString()+" "+e.EmployeeLastName.ToString(),
                    Value = e.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetAssembleList()
        {
            var assembleDTOList = await sa.GetEntity(nameService, serviceGetAssemble);
            List<SelectListItem> items = assembleDTOList.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.AssembleCode.ToString()+" "+a.AssembleDescription.ToString(),
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetNoticeStateList()
        {
            var noticeStateDTOList = await ss.GetEntity(nameService, serviceGetNoticeState);
            List<SelectListItem> items = noticeStateDTOList.ConvertAll(s =>
            {
                return new SelectListItem()
                {
                    Text = s.NoticeStateDescription.ToString(),
                    Value = s.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetNoticeTypeList()
        {
            var noticeTypeDTOList = await nt.GetEntity(nameService, serviceGetNoticeType);
            List<SelectListItem> items = noticeTypeDTOList.ConvertAll(t =>
            {
                return new SelectListItem()
                {
                    Text = t.NoticeTypeDescription.ToString(),
                    Value = t.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public async Task<List<SelectListItem>> GetTechnicalLocationList()
        {
            var technicalLocationDTOList = await tl.GetEntity(nameService, serviceGetTechnicalLocation);
            List<SelectListItem> items = technicalLocationDTOList.ConvertAll(l =>
            {
                return new SelectListItem()
                {
                    Text = l.TechnicalLocationDescription.ToString(),
                    Value = l.Id.ToString(),
                    Selected = false
                };
            });
            return items;
        }
    }
}
