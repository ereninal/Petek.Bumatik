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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        //[SecuredOperation("Member")]
        public List<OperationClaim> GetClaims(Parent user)
        {
            return _userDal.GetClaims(user);
        }
        //[SecuredOperation("Member")]
        public void Add(Parent user)
        {
            _userDal.Add(user);
        }
        //[SecuredOperation("Member")]
        public Parent GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email && u.IsDeleted == false);
        }
        [CacheAspect]
        public IDataResult<List<ParentDTO>> GetParentDTOs()
        {

            return new SuccessDataResult<List<ParentDTO>>(_userDal.GetParents(), "Kullanıcılar listelendi.");
        }
    }
}
