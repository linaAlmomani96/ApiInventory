using System.Collections.Generic;

namespace DataAccess.Generic
{
    public interface IServiceGeneric<T> where T:class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}