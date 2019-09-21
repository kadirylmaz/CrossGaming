using CrossGaming.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CrossGaming.Core.DataAccess
{
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Delete(T entity);
        T Update(T entity);
    }
}
