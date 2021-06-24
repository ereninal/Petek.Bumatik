using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IMenuProcessesService
    {
        IDataResult<List<MenuType>> GetMenuType();
        IDataResult<List<AutomatItemsDTO>> GetItemsDTO();
    }
}
