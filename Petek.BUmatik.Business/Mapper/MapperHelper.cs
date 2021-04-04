using AutoMapper;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Mapper
{
    public class MapperHelper:Profile
    {
        public MapperHelper()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<School, SchoolDTO>()
                .ForMember(dest => dest.SchoolName, opt =>
                 {
                     opt.MapFrom(src => src.Name);
                 });
        }
    }
}
