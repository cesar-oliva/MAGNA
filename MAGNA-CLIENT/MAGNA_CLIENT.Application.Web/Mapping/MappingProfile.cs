using AutoMapper;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Notice;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Object;
using MAGNA_CLIENT.Entities;

namespace MAGNA_CLIENT.Application.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Employee
            CreateMap<RegisterEmployeeRequestDTO, Employee>()
                .ForMember(x => x.EmployeePhotoUrl,o => o.Ignore()); 
            CreateMap<Employee, RegisterEmployeeRequestDTO>();
            //Assemble
            CreateMap<Assemble, RegisterAssembleRequestDTO>();
            CreateMap<RegisterAssembleRequestDTO, Assemble>();
            //Notice
            CreateMap<Notice, RegisterNoticeRequestDTO>();
            CreateMap<RegisterNoticeRequestDTO, Notice>();
            //NoticePriority
            CreateMap<NoticePriority, RegisterNoticePriorityRequestDTO>();
            CreateMap<RegisterNoticePriorityRequestDTO, NoticePriority>();
            //NoticeCategory
            CreateMap<NoticeCategory, RegisterNoticeCategoryRequestDTO>();
            CreateMap<RegisterNoticeCategoryRequestDTO, NoticeCategory>();
            //NoticeState
            CreateMap<RegisterNoticeStateRequestDTO, NoticeState>();
            CreateMap<NoticeState, RegisterNoticeStateRequestDTO>();
            //NoticeType
            CreateMap<RegisterNoticeTypeRequestDTO, NoticeType>();
            CreateMap<NoticeType, RegisterNoticeTypeRequestDTO>();
            //TechnicalLocation
            CreateMap<RegisterTechnicalLocationRequestDTO, TechnicalLocation>();
            CreateMap<TechnicalLocation, RegisterTechnicalLocationRequestDTO>();


        }
    }
}
