using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface ITransactionService
    {
        IDataResult<TransactionDataDTO> GetTransactionData(int parentId);
    }
}
