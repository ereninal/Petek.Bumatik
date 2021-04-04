using AutoMapper;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.Mapper;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.Constants;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        IMapper _mapper;
        public StudentManager(IStudentDal studentDal,IMapper mapper) 
        {
            _studentDal = studentDal;
            _mapper = mapper;
        }

        public IResult Add(Student student)
        {
            if (student.FullName.Length < 2)
                return new ErrorResult(Messages.StudentNameInvalid);

            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IDataResult<List<StudentDTO>> GetAllStudents()
        {
            var data = new SuccessDataResult<List<Student>>(_studentDal.GetAll(m => m.IsDeleted != true), "Öğrenciler listelendi.");
            var dataDTO = _mapper.Map<List<StudentDTO>>(data.Data);
            return new SuccessDataResult<List<StudentDTO>>(dataDTO, "Öğrenciler listelendi."); 

        }

        public IDataResult<List<Student>> GetAllStudentsDetails()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(m => m.IsDeleted != true),"Öğrenciler listelendi.");
        }

        public IDataResult<Student> GetStudentById(int studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(m => m.IsDeleted != true && m.Id == studentId), "Öğrenci listelendi.");
        }

       
    }
}
