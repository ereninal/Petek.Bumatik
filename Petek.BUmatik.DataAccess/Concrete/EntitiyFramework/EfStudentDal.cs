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
        public List<StudentDTO> GetStudentDTOs()
        {
            using (BUmatikContext context = new BUmatikContext())
            {
                var datas = context.Students.Include(s => s.School).Where(m => m.IsDeleted != true).Select(m => new StudentDTO()
                {
                    Fullname = m.FullName,
                    BandNumber = m.BandNumber,
                    RemainingMoney = m.RemainingMoney,
                    SchoolName = m.School.Name

                }).ToList();
                return datas;
            }
        }

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
