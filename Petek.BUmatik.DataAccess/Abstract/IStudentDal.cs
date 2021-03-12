using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IStudentDal
    {
        List<Student> GetStudents();
        void CreatStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        void MoneyUpdate(decimal p);
    }
}
