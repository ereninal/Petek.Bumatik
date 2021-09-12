using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.DataAccess.Concrete.EntitiyFramework;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete
{
    public class EfSchoolDal : EfEntityRepositoryBase<School, BUmatikContext>, ISchoolDal
    {
        public List<SchoolDTO> GetAllSchoolsDetails()
        {
            throw new NotImplementedException();
        }

        public List<SchoolDTO> GetAllSchools()
        {
            using (var context = new BUmatikContext())
            {
                var data = context.Schools.Where(m => m.IsDeleted == false).Select(m => new SchoolDTO()
                {
                    CountryId = m.CountryId,
                    SchoolName = m.Name,
                    Id = m.Id,
                    IsDeleted = m.IsDeleted
                }).ToList();
                return data;
            }
        }

        public School GetStudentById(int schoolId)
        {
            throw new NotImplementedException();
        }
    }
}
