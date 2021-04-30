using Petek.BUmatik.Core.DataAccess;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.DataAccess.Abstract
{
    public interface IAdminUserDal: IEntityRepository<AdminUser>
    {
        //List<AutomatInfo> GetAutomatInfos(); 
        //List<AutomatItem> GetAutomatItems(); 
        //List<Parent> GetParents();
    }
}
