using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T:IEntity
    {
        bool Add(T Entity);

        bool Update(T Entity);

        bool Remove(T Entity);

        T Get(Predicate<T> filter = null);

        List<T> GetAll(Predicate<T> filter = null);
    }
}
