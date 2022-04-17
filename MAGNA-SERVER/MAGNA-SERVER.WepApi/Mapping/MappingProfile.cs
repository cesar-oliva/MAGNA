using AutoMapper;
using MAGNA_SERVER.Entities;
using MAGNA_SERVER.WebApi.DataTransferObject;

namespace MAGNA_SERVER.WebApi.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<RegisterEmployeeRequestDTO, Employee>();
            CreateMap<Employee, RegisterEmployeeRequestDTO>();
            CreateMap<AssembleType, RegisterAssembleTypeRequestDTO>();
            CreateMap<RegisterAssembleTypeRequestDTO,AssembleType >();
            CreateMap<RegisterAssembleRequestDTO, Assemble>();
            CreateMap<Assemble, RegisterAssembleRequestDTO>();
                
                
            // en el caso de que los nombres no coincidan con el DTO - dominio
            //CreateMap<EmployeeDTO, Employee>()
            //  .ForMember( d => d.EmployeeFirstName, 
            //              o => o.MapFrom(
            //              s => s.PrimerNombre));   

        }
    }
}
