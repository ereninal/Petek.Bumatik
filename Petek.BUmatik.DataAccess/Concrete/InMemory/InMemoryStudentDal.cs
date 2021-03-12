using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.InMemory
{
    public class InMemoryStudentDal : IStudentDal
    {
        List<Student> _students;

        public InMemoryStudentDal()
        {
            _students = new List<Student> {
                new Student{Id=1,BandNumber="32452343422fds",FullName="Adem Yılmaz",SchoolId=2,IsDeleted=false,CreatedDate=DateTime.Now,CreatedUserId=1,RemainMoney=60},
                new Student{Id=2,BandNumber="52343422fghgf",FullName="Hakan Tatar",SchoolId=1,IsDeleted=false,CreatedDate=DateTime.Now,CreatedUserId=1,RemainMoney=10}
            
            
            };
        }
        public void CreatStudent(Student student)
        {
            _students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            var updateDeleteStudent = _students.FirstOrDefault(m=>m.IsDeleted!=true && m.Id == student.Id);
            updateDeleteStudent.IsDeleted = true;
            
            
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public void MoneyUpdate(decimal p)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            var updateStudent = _students.FirstOrDefault(m => m.IsDeleted != true && m.Id == student.Id);
            updateStudent.Image = student.Image;
            updateStudent.FullName = student.FullName;
            updateStudent.ModifiedDate = DateTime.Now;
            
        }
    }
}
