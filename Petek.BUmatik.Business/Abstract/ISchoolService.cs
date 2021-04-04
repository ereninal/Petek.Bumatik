using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface ISchoolService
    {
        IDataResult<School> GetSchoolById(int schoolId);
        IDataResult<List<SchoolDTO>> GetAllSchools();
        IResult Add(School school);
        IDataResult<List<School>> GetAllSchoolsDetails();
    }
}
