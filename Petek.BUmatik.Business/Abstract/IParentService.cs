using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IParentService
    {
        List<OperationClaim> GetClaims(Parent user);
        void Add(Parent user);
        void StudentAdd(Student student);
        IDataResult<List<ParentDTO>> GetParentDTOs();
        IDataResult<List<StudentDTO>> GetStudentsByParent(int? id);
        IDataResult<SelectedMenuDetailsDTO> GetStudentMenuDetails(int id, int menuTypeId,DateTime useDate);
        IDataResult<List<SelectedMenusDTO>> GetSelectedMenusByStudent(int id);
        IDataResult<List<StudentMenusDTO>> GetAllSelectedMenusByStudent(int id);
        Parent GetByMail(string email);
        IResult AddStudentByParent(Student student);
        IResult AddSelectedMenuByStudent(SelectedMenuItemDTO selectedMenuItems);




    }
}
