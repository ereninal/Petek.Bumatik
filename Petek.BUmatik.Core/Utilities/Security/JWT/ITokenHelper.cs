using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Parent user, List<OperationClaim> operationClaims);
        AccessToken AdminCreateToken(AdminUser user);
    }
}
