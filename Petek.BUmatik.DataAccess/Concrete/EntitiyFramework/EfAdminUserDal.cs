using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfAdminUserDal : EfEntityRepositoryBase<AdminUser, BUmatikContext>, IAdminUserDal
    {
        public void AdminUserAdd(AdminUser Add)
        {
            using (var context = new BUmatikContext())
            {
                context.AdminUsers.Add(Add);
                context.SaveChanges();
            }
        }

        public List<OperationClaim> GetClaims(AdminUser user)
        {
            throw new NotImplementedException();
        }

        public List<AdminUser> GetParents()
        {
            throw new NotImplementedException();
        }

        public void StudentAdd(Student Add)
        {
            throw new NotImplementedException();
        }
    }
}
