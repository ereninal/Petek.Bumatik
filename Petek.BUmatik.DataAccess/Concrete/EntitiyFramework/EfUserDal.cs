using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Petek.BUmatik.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<Parent, BUmatikContext>, IUserDal
    {
        public void AdminUserAdd(AdminUser Add)
        {
            using (var context = new BUmatikContext())
            {
                context.AdminUsers.Add(Add);
                context.SaveChanges();
            }
        }

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

        public List<ParentDTO> GetParents()
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.Parents.Where(m => m.IsDeleted == false).Select(m => new ParentDTO() { 
                    Email = m.Email,
                    Fullname = m.FullName,
                    PasswordHash = m.PasswordHash,
                    PasswordSalt = m.PasswordSalt
                }).ToList();

                return datas;
            }
        }

        public List<StudentDTO> GetStudentsByParent(int? id)
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.Students.Include(s=>s.Schools).Where(m => m.IsDeleted == false && m.ParentId == id).Select(m => new StudentDTO()
                {
                    BandNumber = m.BandNumber,
                    Fullname = m.FullName,
                    RemainingMoney = m.RemainingMoney,
                    SchoolName = m.Schools.Name

                }).ToList();
                return datas;
            }
        }

        public void StudentAdd(Student student)
        {
            using (var context = new BUmatikContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
