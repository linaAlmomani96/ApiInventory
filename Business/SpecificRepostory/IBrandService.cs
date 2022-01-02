using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface IBrandService
    {
        void Insert(Brand brand);
        void Update(Brand brand);
        void Delete(int id);
        Brand GetById(int id);
        List<Brand> GetAll();
        List<Brand> GetByName(string name);
    }
}