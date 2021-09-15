using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class DashboardManager : IDashboardService
    {
        IStudentDal _studentDal;
        IParentDal _parentDal;
        ISchoolDal _schoolDal;
        public DashboardManager(IStudentDal studentDal,IParentDal parentDal,ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
            _studentDal = studentDal;
            _parentDal = parentDal;
        }
        [SecuredOperation("Admin,Member")]
        public IDataResult<StatisticDashboardDTO> GetStatisticDashboardData(int parentId)
        {
            StatisticDashboardDTO data = new StatisticDashboardDTO();
            data.TotalStudent = _studentDal.GetCount(m=>m.IsDeleted == false && m.ParentId == parentId); 
            data.TotalActiveMenu = _parentDal.GetActiveMenuCount(parentId); 
            data.TotalOrder = _parentDal.GetTotalOrderCount(parentId); 
            data.TotalPrice = _studentDal.GetCount(m=>m.IsDeleted == false); 
            return new SuccessDataResult<StatisticDashboardDTO>(data, "İstatistik dashboard verileri listelendi");
        }
    }
}
