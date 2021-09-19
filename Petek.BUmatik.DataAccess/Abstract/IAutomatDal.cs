using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IAutomatDal
    {
        List<AutomatItemsDTO> GetAutomatItemsDTOs();
        List<MenuTypeDTO> GetMenuTypeDTOs();
        List<SelectedItemsDTO> GetMenuItemsByStudent(string bandNumber, DateTime useDate, int menuTypeId);
        SelectedMenuDetailsDTO GetStudentMenuDetailsByBandNumber(string bandNumber);
        SelectedMenuPackageDTO GetStudentMenuDetailsPackageByBandNumber(string bandNumber);

        void ItemAdd(AutomatItem item);
    }
}
