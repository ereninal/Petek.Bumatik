using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, BUmatikContext>, IStudentDal
    {
        public List<StudentDTO> GetStudentSummary()
        {
            using (BUmatikContext context = new BUmatikContext())
            {
                var result = from p in context.Students
                             join c in context.Schools
                             on p.SchoolId equals c.Id
                             select new StudentDTO
                             {
                                 SchoolName = c.Name,
                                 BandNumber = p.BandNumber,
                                 Fullname = p.FullName,
                                 RemainingMoney = p.RemainingMoney

                             };
                return result.ToList();

            }
        }
    }
}
