using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<Parent, BUmatikContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(Parent user)
        {
            using (var context = new BUmatikContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.ParentId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
