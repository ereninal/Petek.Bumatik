using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(Parent user);
        void Add(Parent user);
        Parent GetByMail(string email);
    }
}
