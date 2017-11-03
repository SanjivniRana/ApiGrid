using ApiGrid.Dto;
using ApiGrid.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGrid.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDetail, StudentDetailDto>();

            // Dto to Domain
            CreateMap<StudentDto, Student>()
            .ForMember(c => c.SId, opt => opt.Ignore());
        }
    }
}