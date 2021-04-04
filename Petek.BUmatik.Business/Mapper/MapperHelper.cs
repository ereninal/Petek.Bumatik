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
            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.Fullname, opt =>
                {
                    opt.MapFrom(src => src.FullName);
                })
                .ForMember(dest => dest.BandNumber, opt =>
                {
                    opt.MapFrom(src => src.BandNumber);
                })
                .ForMember(dest => dest.RemainingMoney, opt =>
                {
                    opt.MapFrom(src => src.RemainingMoney);
                })
                .ForMember(dest => dest.SchoolName, opt =>
                {
                    opt.MapFrom(src => src.School.Name);
                });
            CreateMap<School, SchoolDTO>()
                .ForMember(dest => dest.SchoolName, opt =>
                 {
                     opt.MapFrom(src => src.Name);
                 });
        }
    }
}
