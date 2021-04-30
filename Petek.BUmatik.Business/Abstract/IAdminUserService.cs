using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IAdminUserService
    {
        AdminUser AdminUserGetByMail(string email);
        void AdminUserAdd(AdminUser user);

    }
}
