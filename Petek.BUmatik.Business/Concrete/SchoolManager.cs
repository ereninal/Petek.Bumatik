using AutoMapper;
using Petek.BUmatik.Business.Abstract;
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
        IMapper _mapper;
        public SchoolManager(ISchoolDal schoolDal, IMapper mapper)
        {
            _schoolDal = schoolDal;
            _mapper = mapper;
        }


        public IResult Add(School school)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SchoolDTO>> GetAllSchools()
        {
            var data = new SuccessDataResult<List<School>>(_schoolDal.GetAll(m => m.IsDeleted != true), "Öğrenciler listelendi.");
            var dataDTO = _mapper.Map<List<SchoolDTO>>(data.Data);
            return new SuccessDataResult<List<SchoolDTO>>(dataDTO, "Öğrenciler listelendi.");
        }

        public IDataResult<List<School>> GetAllSchoolsDetails()
        {
            return  new SuccessDataResult<List<School>>(_schoolDal.GetAll(m => m.IsDeleted != true), "Okullar listelendi.");
        }

        public IDataResult<School> GetSchoolById(int schoolId)
        {
            throw new NotImplementedException();
        }
    }
}
