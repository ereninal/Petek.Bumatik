using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
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

        public List<Student> GetStudents()
        {
            return _studentDal.GetStudents();
        }
    }
}
