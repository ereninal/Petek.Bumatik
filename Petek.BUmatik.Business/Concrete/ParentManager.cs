using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Business.ValidationRules.FluentValidation;
using Petek.BUmatik.Core.Aspects.Autofac.Caching;
using Petek.BUmatik.Core.Aspects.Autofac.Validation;
using Petek.BUmatik.Core.Utilities.Business;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.Constants;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class ParentManager : IParentService
    {
        IParentDal _parentDal;
        IStudentDal _studentDal;

        public ParentManager(IParentDal parentDal, IStudentDal studentDal)
        {
            _parentDal = parentDal;
            _studentDal = studentDal;
        }
        public List<OperationClaim> GetClaims(Parent parent)
        {
            return _parentDal.GetClaims(parent);
        }
        //[SecuredOperation("Admin")]
        public void Add(Parent parent)
        {
            _parentDal.Add(parent);
        }
        public Parent GetByMail(string email)
        {
            return _parentDal.Get(u => u.Email == email && u.IsDeleted == false);
        }
        [CacheAspect]
        public IDataResult<List<ParentDTO>> GetParentDTOs()
        {
            return new SuccessDataResult<List<ParentDTO>>(_parentDal.GetParents(), "Kullanıcılar listelendi.");
        }
        [SecuredOperation("Member")]
        public void StudentAdd(Student student)
        {
            _parentDal.StudentAdd(student);
        }
        [SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<StudentDTO>> GetStudentsByParent(int? id)
        {
            return new SuccessDataResult<List<StudentDTO>>(_parentDal.GetStudentsByParent(id), "Kullanıcılar listelendi.");
        }
        [SecuredOperation("Admin,Member")]
        [ValidationAspect(typeof(StudentValidator))]
        [CacheRemoveAspect("IParentService.Get")]//herşey interface üzerinden oluyor. Tümü silmek içini tırnak içine Get yazdığımızda tüm get isteklerini siler -Eren
        public IResult AddStudentByParent(Student student)
        {
            IResult result = BusinessRules.Run(CheckIfStudentBandNumberExists(student.BandNumber));
            if (result != null)
                return result;
            _parentDal.StudentAdd(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        [SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<SelectedMenuDetailsDTO> GetStudentMenuDetails(int id, int menuTypeId, DateTime useDate)
        {
            return new SuccessDataResult<SelectedMenuDetailsDTO>(_parentDal.GetStudentMenuDetails(id, menuTypeId, useDate), "Menü detayları listelendi.");
        }
        //[SecuredOperation("Admin,Member")]
        //[ValidationAspect(typeof(StudentValidator))]
        [CacheRemoveAspect("IParentService.Get")]
        public IResult AddSelectedMenuByStudent(SelectedMenuItemDTO selectedMenuItems)
        {
            _parentDal.StudentMenuDetailsAdd(selectedMenuItems);
            return new SuccessResult(Messages.MenuAdd);
        }
        //[SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<SelectedMenusDTO>> GetSelectedMenusByStudent(int id)
        {
            return new SuccessDataResult<List<SelectedMenusDTO>>(_parentDal.GetSelectedMenusByStudent(id), "Öğrenciye ait tüm menüler detayları listelendi.");

        }
        //[SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<StudentMenusDTO>> GetAllSelectedMenusByStudent(int id)
        {
            return new SuccessDataResult<List<StudentMenusDTO>>(_parentDal.GetAllSelectedMenusByStudent(id), "Öğrenciye ait tüm menüler detayları listelendi.");

        }
        private IResult CheckIfStudentBandNumberExists(string bandNumber)
        {
            var result = _studentDal.GetAll(p => p.BandNumber == bandNumber && p.IsDeleted == false).Any();
            if (result)
            {
                return new ErrorResult(Messages.StudentBandNumberAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}
