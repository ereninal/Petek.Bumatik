using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.Concrete;
using Petek.BUmatik.Core.Utilities.Interceptors;
using Petek.BUmatik.Core.Utilities.Security.JWT;
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

            builder.RegisterType<ParentManager>().As<IParentService>();
            builder.RegisterType<AdminUserManager>().As<IAdminUserService>();

            builder.RegisterType<AutomatManager>().As<IAutomatService>();
            builder.RegisterType<EfAutomatDal>().As<IAutomatDal>();

            builder.RegisterType<EfParentDal>().As<IParentDal>();
            builder.RegisterType<EfAdminUserDal>().As<IAdminUserDal>();

            builder.RegisterType<EfSchoolDal>().As<ISchoolDal>();
            builder.RegisterType<SchoolManager>().As<ISchoolService>();

            builder.RegisterType<EfTransactionDal>().As<ITransactionDal>();
            builder.RegisterType<TransactionManager>().As<ITransactionService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


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

           

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
