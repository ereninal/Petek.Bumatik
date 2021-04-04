using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.DataAccess.Concrete.EntitiyFramework;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete
{
    public class EfSchoolDal : EfEntityRepositoryBase<School, BUmatikContext>, ISchoolDal
    {
    }
}
