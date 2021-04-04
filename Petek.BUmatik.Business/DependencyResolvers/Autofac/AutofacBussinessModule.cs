using Autofac;
using AutoMapper;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.Concrete;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.DataAccess.Concrete;
using Petek.BUmatik.DataAccess.Concrete.EntitiyFramework;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.DependencyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();
            builder.RegisterType<SchoolManager>().As<ISchoolService>().SingleInstance();
            builder.RegisterType<EfSchoolDal>().As<ISchoolDal>().SingleInstance();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
               
            })).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                //This resolves a new context that can be used later.
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
        }
    }
}
