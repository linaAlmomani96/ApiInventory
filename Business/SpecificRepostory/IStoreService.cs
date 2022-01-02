using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface IStoreService
    {
        void Insert(Store store);
        void Update(Store store);
        void Delete(int id);
        Store GetById(int id);
        List<Store> GetAll();
        List<Store> GetByName(string name);
    }
}