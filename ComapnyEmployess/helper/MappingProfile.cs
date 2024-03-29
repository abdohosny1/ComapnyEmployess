﻿using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace ComapnyEmployess.helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Company, CompanyDto>()
            //.ForCtorParam("FullAddress",
            CreateMap<Company, CompanyDto>()
                    .ForMember(c => c.FullAddress,
            opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>();

            CreateMap<CompanyForCreationDto, Company>();

            CreateMap<EmployeeForCreationDto, Employee>();



        }


    }
}
