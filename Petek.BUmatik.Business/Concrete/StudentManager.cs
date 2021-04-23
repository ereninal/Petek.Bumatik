using AutoMapper;
using FluentValidation;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Business.Mapper;
using Petek.BUmatik.Business.ValidationRules.FluentValidation;
using Petek.BUmatik.Core.Aspects.Autofac.Caching;
using Petek.BUmatik.Core.Aspects.Autofac.Validation;
using Petek.BUmatik.Core.CrossCuttingConcerns.Caching;
using Petek.BUmatik.Core.CrossCuttingConcerns.Validation;
using Petek.BUmatik.Core.Utilities.Business;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.Constants;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [SecuredOperation("Student.Add,Admin")]
        [ValidationAspect(typeof(StudentValidator))]
        [CacheRemoveAspect("IStudentService.Get")]//herşey interface üzerinden oluyor. Tümü silmek içini tırnak içine Get yazdığımızda tüm get isteklerini siler -Eren
        public IResult Add(Student student)
        {
            IResult result = BusinessRules.Run(CheckIfStudentBandNumberExists(student.BandNumber));

            if (result != null)
                return result;

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
        [CacheAspect]
        public IDataResult<List<StudentDTO>> GetStudentDTOs()
        {

            return new SuccessDataResult<List<StudentDTO>>(_studentDal.GetStudentDTOs(), "Öğrenciler listelendi.");
        }

        public IDataResult<List<StudentDTO>> GetStudentSummary()
        {
            return new SuccessDataResult<List<StudentDTO>>(_studentDal.GetStudentSummary(), "Öğrenciler listelendi.");
        }
        private IResult CheckIfStudentBandNumberExists(string bandNumber)
        {
            var result = _studentDal.GetAll(p => p.BandNumber == bandNumber && p.IsDeleted == false).Any();
            if (result)
            {
                return new ErrorResult(Messages.StudentBandNumberAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
