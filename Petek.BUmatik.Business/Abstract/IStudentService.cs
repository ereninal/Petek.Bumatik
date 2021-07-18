using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<StudentDTO> GetStudentById(int studentId);
        IDataResult<List<StudentDTO>> GetAllStudents();
        IResult Add(Student student);
        IDataResult<List<Student>> GetAllStudentsDetails();
        IDataResult<List<StudentDTO>> GetStudentSummary();
        IDataResult<List<StudentDTO>> GetStudentDTOs();
    }
}
