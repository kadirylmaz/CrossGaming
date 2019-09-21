using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Business.Abstract
{
    public interface IBaseService<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T entity);
        void Edit(int id,T entity);
        void Remove(int id);

    }
}
