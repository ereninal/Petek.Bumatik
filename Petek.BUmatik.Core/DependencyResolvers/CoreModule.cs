using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Petek.BUmatik.Core.CrossCuttingConcerns.Caching;
using Petek.BUmatik.Core.CrossCuttingConcerns.Caching.Microsoft;
using Petek.BUmatik.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
