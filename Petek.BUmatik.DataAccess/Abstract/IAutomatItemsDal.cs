using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IAutomatItemsDal
    {
        List<AutomatItemsDTO> GetAutomatItemsDTOs();
        void ItemAdd(AutomatItem item);
    }
}
