using Admin.App.Mvc.Dtos;
using Admin.App.Mvc.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.App.Mvc.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Employee, EmployeeForRegisterDto>();
            Mapper.CreateMap<EmployeeForRegisterDto,Employee>();
        }
    }
}