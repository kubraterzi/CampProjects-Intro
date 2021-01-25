using GameCenter.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Abstract
{
    public interface IManagerService<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Get(T entity);
        void GetAll(List<T> entities);
    }
}
