using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Core.Aspects.Autofac.Caching;
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
    public class AutomatManager : IAutomatService
    {
        IAutomatDal _automatDal;
        IStudentDal _studentDal;

        public AutomatManager(IAutomatDal automatDal, IStudentDal studentDal)
        {
            _automatDal = automatDal;
            _studentDal = studentDal;
        }
        [SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<AutomatItemsDTO>> GetItemsDTO()
        {
            return new SuccessDataResult<List<AutomatItemsDTO>>(_automatDal.GetAutomatItemsDTOs(), "Automatın içindekiler listelendi.");
        }
        //[SecuredOperation("Admin,Member")]
        [CacheAspect]
        public IDataResult<List<SelectedItemsDTO>> GetMenuItemsByStudent(string bandNumber, DateTime useDate, int menuTypeId)
        {
            IResult result = BusinessRules.Run(CheckIfStudentBandNumberExists(bandNumber));
            if (result != null)
                return new ErrorDataResult<List<SelectedItemsDTO>>(result.Message);
            return new SuccessDataResult<List<SelectedItemsDTO>>(_automatDal.GetMenuItemsByStudent(bandNumber, useDate, menuTypeId), "Öğrencinin öğün bilgisi listelendi.");
        }

        public IDataResult<List<MenuType>> GetMenuType()
        {
            throw new NotImplementedException();
        }
        private IResult CheckIfStudentBandNumberExists(string bandNumber)
        {
            var result = _studentDal.GetAll(p => p.BandNumber == bandNumber && p.IsDeleted == false).Any();
            if (!result)
            {
                return new ErrorResult(Messages.StudentBandNumberDontExists);
            }
            return new SuccessResult();
        }
        

    }
}
