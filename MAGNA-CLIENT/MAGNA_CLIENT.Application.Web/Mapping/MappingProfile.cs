using AutoMapper;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Entities;

namespace MAGNA_CLIENT.Application.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterEmployeeRequestDTO, Employee>()
                .ForMember(x => x.EmployeePhotoUrl,o => o.Ignore()); // ignora el mappeo de esta propiedad

            CreateMap<Employee, RegisterEmployeeRequestDTO>();
            CreateMap<Assemble, RegisterAssembleRequestDTO>();
     
            CreateMap<RegisterAssembleRequestDTO, Assemble>();
  
            //.ForMember(x => x.EmployeePhotoUrl, o => o.MapFrom(s => s.EmployeePhotoUrl.FileName));

            // en el caso de que los nombres no coincidan con el DTO - dominio
            //CreateMap<EmployeeDTO, Employee>()
            //  .ForMember( d => d.EmployeeFirstName, 
            //              o => o.MapFrom(
            //              s => s.PrimerNombre));

        }
    }
}
