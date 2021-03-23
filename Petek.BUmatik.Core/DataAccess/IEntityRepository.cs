using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Petek.BUmatik.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//parametre olarak filtre gönderebilmemiz için yzdığımız kod
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
