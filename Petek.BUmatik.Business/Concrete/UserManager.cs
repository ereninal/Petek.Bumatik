using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
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

        public List<OperationClaim> GetClaims(Parent user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(Parent user)
        {
            _userDal.Add(user);
        }

        public Parent GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
