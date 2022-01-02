using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface IProductService
    {
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> GetByName(string name);
    }
}