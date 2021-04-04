using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class SchoolService : ISchoolService
    {
        public IResult Add(School school)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SchoolDTO>> GetAllSchools()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<School>> GetAllSchoolsDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<School> GetStudentById(int schoolId)
        {
            throw new NotImplementedException();
        }
    }
}
