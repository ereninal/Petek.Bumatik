using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfTransactionDal : EfEntityRepositoryBase<Transaction, BUmatikContext>, ITransactionDal
    {
        public List<TransactionDataDTO> GetTransactionData(int parentId)
        {
            using (var context = new BUmatikContext())
            {
                var studentIds = context.Students.Where(m => m.IsDeleted == false && m.ParentId == parentId).Select(m => m.Id).ToList();
                var datas = new List<TransactionDataDTO>();
                foreach (var item in studentIds)
                {
                    var dtoData = context.Transactions.Include(m => m.Student).Where(m => m.IsDeleted == false && m.StudentId == item).Select(m => new TransactionDataDTO()
                    {
                        StudentName = m.Student.FullName,
                        UseDate = m.CreatedDate
                    }).ToList();
                    datas.AddRange(dtoData);

                }
                return datas;
            }
        }
    }
}
