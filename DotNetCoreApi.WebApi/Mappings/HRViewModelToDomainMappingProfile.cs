using AutoMapper;
using DotNetCoreApi.Model;
using DotNetCoreApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetCoreApi.WebApi.Mappings
{
    public class HRViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "HRViewModelToDomainMappings"; }
        }
        public HRViewModelToDomainMappingProfile()
        {
            CreateMap<EmployeeMasterFormViewModel, EmployeeMasterModel>()
              .ForMember(e => e.FirstName, map => map.MapFrom(vm => vm.FirstName))
              .ForMember(e => e.LastName, map => map.MapFrom(vm => vm.LastName))
              .ForMember(e => e.Gender, map => map.MapFrom(vm => vm.Gender))
              .ForMember(e => e.BirthDate, map => map.MapFrom(vm => vm.BirthDate))
              .ForMember(e => e.Mobile, map => map.MapFrom(vm => vm.Mobile))
              .ForMember(e => e.EmailAddress, map => map.MapFrom(vm => vm.EmailAddress))
              .ForMember(e => e.IsFavourite, map => map.MapFrom(vm => vm.IsFavourite))
              .ForMember(e => e.DisplayOrder, map => map.MapFrom(vm => vm.DisplayOrder))
              .ForMember(e => e.EmployeeMasterDeleted, map => map.MapFrom(vm => vm.EmployeeMasterDeleted))
              .ForMember(e => e.EmployeeMasterUserUpdated, map => map.MapFrom(vm => vm.EmployeeMasterUserUpdated))
              .ForMember(e => e.EmployeeMasterUpdatedDateTime, map => map.MapFrom(vm => vm.EmployeeMasterUpdatedDateTime));
        }
    }
}