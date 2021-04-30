using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    class AdminUserManager : IAdminUserService
    {
        IAdminUserDal _adminUserDal;
        public AdminUserManager(IAdminUserDal adminUserDal)
        {
            _adminUserDal = adminUserDal;

        }
        public void AdminUserAdd(AdminUser user)
        {
            _adminUserDal.AdminUserAdd(user);
        }

        public AdminUser AdminUserGetByMail(string email)
        {
            return _adminUserDal.Get(u => u.Email == email && u.IsDeleted == false);
        }
    }
}
