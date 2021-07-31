using Petek.BUmatik.Core.DataAccess;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IParentDal : IEntityRepository<Parent>
    {
        List<OperationClaim> GetClaims(Parent user);
        List<ParentDTO> GetParents();
        List<StudentDTO> GetStudentsByParent(int? id);

        SelectedMenuDetailsDTO GetStudentMenuDetails(int id, int menuTypeId,DateTime useDate);
        List<SelectedMenusDTO> GetSelectedMenusByStudent(int id);
        List<StudentMenusDTO> GetAllSelectedMenusByStudent(int id);
        void StudentMenuDetailsAdd(SelectedMenuItemDTO selectedMenuItems);
        void StudentAdd(Student Add);
        void AdminUserAdd(AdminUser Add);
    }
}
