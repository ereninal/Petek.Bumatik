using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Core.Aspects.Autofac.Caching;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class MenuProcessesManager : IMenuProcessesService
    {
        IAutomatItemsDal _automatItemsDal;
        public MenuProcessesManager(IAutomatItemsDal automatItemsDal)
        {
            _automatItemsDal = automatItemsDal;
        }
        //[SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<AutomatItemsDTO>> GetItemsDTO()
        {
            return new SuccessDataResult<List<AutomatItemsDTO>>(_automatItemsDal.GetAutomatItemsDTOs(), "Automatın içindekiler listelendi.");
        }

        public IDataResult<List<MenuType>> GetMenuType()
        {
            throw new NotImplementedException();
        }
    }
}
