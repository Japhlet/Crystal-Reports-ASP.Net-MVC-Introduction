using AutoMapper;
using CrystalReportsAsp.netMVCIntro.Models;
using CrystalReportsAsp.netMVCIntro.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalReportsAsp.netMVCIntro.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeVM, Employee>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
            CreateMap<Employee, EmployeeVM>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}