using AutoMapper;
using BusinessLogic.DTOS;
using DomainLogic.Models;

namespace VehicleBranding
{
    public class MappingConfig 
    {
        public static MapperConfiguration RegisterMapper()
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<ClientModel,ClientModelDTO>().ReverseMap();
                config.CreateMap<EmployeeModel,EmployeeModelDTO>().ReverseMap();
                config.CreateMap<ProjectModel,ProjectModelDTO>().ReverseMap();
                config.CreateMap<ProjectResourceMappingModel,ProjectResourceMappingModelDTO>().ReverseMap();


            });
            return mapper;
        }
    }
}
