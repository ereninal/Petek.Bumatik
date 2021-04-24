using Petek.BUmatik.Core.DataAccess;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<Parent>
    {
        List<OperationClaim> GetClaims(Parent user);
        List<ParentDTO> GetParents();
    }
}
