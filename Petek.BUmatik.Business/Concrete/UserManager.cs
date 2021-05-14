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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IStudentDal _studentDal;
       
        public UserManager(IUserDal userDal,IStudentDal studentDal)
        {
            _userDal = userDal;
            _studentDal = studentDal;
        }
        public List<OperationClaim> GetClaims(Parent user)
        {
            return _userDal.GetClaims(user);
        }
        //[SecuredOperation("Admin")]
        public void Add(Parent user)
        {
            _userDal.Add(user);
        }
        public Parent GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email && u.IsDeleted == false);
        }
        [CacheAspect]
        public IDataResult<List<ParentDTO>> GetParentDTOs()
        {
            return new SuccessDataResult<List<ParentDTO>>(_userDal.GetParents(), "Kullanıcılar listelendi.");
        }
        [SecuredOperation("Member")]
        public void StudentAdd(Student student)
        {
            _userDal.StudentAdd(student);
        }
        //[SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<StudentDTO>> GetStudentsByParent(int? id)
        {
            return new SuccessDataResult<List<StudentDTO>>(_userDal.GetStudentsByParent(id), "Kullanıcılar listelendi.");
        }
        [SecuredOperation("Admin,Member")]
        [ValidationAspect(typeof(StudentValidator))]
        [CacheRemoveAspect("IUserService.Get")]//herşey interface üzerinden oluyor. Tümü silmek içini tırnak içine Get yazdığımızda tüm get isteklerini siler -Eren
        public IResult AddStudentByParent(Student student)
        {
            IResult result = BusinessRules.Run(CheckIfStudentBandNumberExists(student.BandNumber));
            if (result != null)
                return result;
            _userDal.StudentAdd(student);
            return new SuccessResult(Messages.StudentAdded);
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
