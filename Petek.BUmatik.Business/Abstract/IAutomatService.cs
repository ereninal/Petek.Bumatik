using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IAutomatService
    {
        IDataResult<List<AutomatItemsDTO>> GetItemsDTO();
        IDataResult<List<MenuTypeDTO>> GetMenuTypeDTO();
        IDataResult<List<SelectedItemsDTO>> GetMenuItemsByStudent(string bandNumber, DateTime useDate, int menuTypeId);
        IDataResult<SelectedMenuDetailsDTO> GetStudentMenuDetailsByBandNumber(string bandNumber);
        IDataResult<SelectedMenuPackageDTO> GetStudentMenuDetailsPackageByBandNumber(string bandNumber);
    }
}
