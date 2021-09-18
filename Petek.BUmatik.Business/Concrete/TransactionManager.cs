using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class TransactionManager : ITransactionService
    {
        ITransactionDal _transactionDal;
        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }
        public IDataResult<TransactionDataDTO> GetTransactionData(int parentId)
        {
            return new SuccessDataResult<TransactionDataDTO>(_transactionDal.GetTransactionData(parentId), "Transaction Widget dataları listelendi.");
        }
    }
}
