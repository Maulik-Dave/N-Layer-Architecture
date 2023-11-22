using AutoMapper;
using DotNetCoreApi.Model;
using DotNetCoreApi.ViewModel;

namespace DotNetCoreApi.WebApi.Mappings
{
    public class HRDomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "HRDomainToViewModelMappings"; }
        }

        public HRDomainToViewModelMappingProfile()
        {
            // HR Models
            CreateMap<EmployeeMasterModel, EmployeeMasterFormViewModel>();
            CreateMap<EmployeeMasterModel, EmployeeMasterViewModel>();
        }
    }
}