using AutoMapper;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;

namespace MAGNA_SERVER.WebApi.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            //Employee
            CreateMap<RegisterEmployeeRequestDTO, Employee>();
            CreateMap<Employee, RegisterEmployeeRequestDTO>();
            //AssembleType
            CreateMap<AssembleType, RegisterAssembleTypeRequestDTO>();
            CreateMap<RegisterAssembleTypeRequestDTO,AssembleType >();
            //Assemble
            CreateMap<RegisterAssembleRequestDTO, Assemble>()
            .ForMember(c => c.AssembleSubAssemblies, option => option.Ignore())
            .ForMember(c => c.Notice, option => option.Ignore());
            CreateMap<Assemble, RegisterAssembleRequestDTO>();


            //Notice
            CreateMap<RegisterNoticeRequestDTO, Notice>();
            CreateMap<Notice,RegisterNoticeRequestDTO>();
            //NoticePriority
            CreateMap<RegisterNoticePriorityRequestDTO, NoticePriority>();
            CreateMap<NoticePriority, RegisterNoticePriorityRequestDTO>();
            //NoticeCategory
            CreateMap<RegisterNoticeCategoryRequestDTO, NoticeCategory>();
            CreateMap<NoticeCategory, RegisterNoticeCategoryRequestDTO>();
            //NoticeState
            CreateMap<RegisterNoticeStateRequestDTO, NoticeState>();
            CreateMap<NoticeState, RegisterNoticeStateRequestDTO>();
            //NoticeType
            CreateMap<RegisterNoticeTypeRequestDTO, NoticeType>();
            CreateMap<NoticeType, RegisterNoticeTypeRequestDTO>();
            //TechnicalLocation
            CreateMap<RegisterTechnicalLocationRequestDTO, TechnicalLocation>();
            CreateMap<TechnicalLocation, RegisterTechnicalLocationRequestDTO>();


            // en el caso de que los nombres no coincidan con el DTO - dominio
            //CreateMap<EmployeeDTO, Employee>()
            //  .ForMember( d => d.EmployeeFirstName, 
            //              o => o.MapFrom(
            //              s => s.PrimerNombre));   

        }
    }
}
