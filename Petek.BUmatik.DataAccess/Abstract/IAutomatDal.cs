﻿using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IAutomatDal
    {
        List<AutomatItemsDTO> GetAutomatItemsDTOs();
        List<SelectedItemsDTO> GetMenuItemsByStudent(string bandNumber, DateTime useDate, int menuTypeId);
        void ItemAdd(AutomatItem item);
    }
}