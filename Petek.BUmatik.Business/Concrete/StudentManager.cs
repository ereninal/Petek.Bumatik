using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal) 
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            if (student.FullName.Length < 2)
                return new ErrorResult(Messages.StudentNameInvalid);

            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IDataResult<List<Student>> GetAllStudents()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(m => m.IsDeleted != true),"Öğrenciler listelendi.");
        }

        public Student GetStudentById(int studentId)
        {
            return _studentDal.Get(m => m.IsDeleted != true && m.Id == studentId);
        }

       
    }
}
