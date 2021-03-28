using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<Student> GetStudentById(int studentId);
        IDataResult<List<Student>> GetAllStudents();
        IResult Add(Student student);
    }
}
