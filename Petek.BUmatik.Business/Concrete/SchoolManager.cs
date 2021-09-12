using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class SchoolManager : ISchoolService
    {
        ISchoolDal _schoolDal;
        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }
        public IResult Add(School school)
        {
            throw new NotImplementedException();
        }
        [SecuredOperation("Admin,Member")]
        public IDataResult<List<SchoolDTO>> GetAllSchoolsDetails()
        {
            throw new NotImplementedException();
        }
        //[SecuredOperation("Admin,Member")]
        public IDataResult<List<SchoolDTO>> GetAllSchools()
        {
            return new SuccessDataResult<List<SchoolDTO>>(_schoolDal.GetAllSchools(), "Okullar listelendi.");
        }
        [SecuredOperation("Admin,Member")]
        public IDataResult<School> GetStudentById(int schoolId)
        {
            throw new NotImplementedException();
        }
    }
}
