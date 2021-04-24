using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(Parent user);
        void Add(Parent user);
        IDataResult<List<ParentDTO>> GetParentDTOs();

        Parent GetByMail(string email);
    }
}
