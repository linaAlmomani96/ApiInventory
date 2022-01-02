using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class ProductService:IProductService
    {
        private readonly IServiceGeneric<Product> serviceGeneric;
        private readonly InventoryContext Context;

        public ProductService(IServiceGeneric<Product> _serviceGeneric, InventoryContext _context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _context;
        }
         
        public void Insert(Product product)
        {
            serviceGeneric.Insert(product);
        }
         public void Update(Product product)
        {
            serviceGeneric.Update(product);
        }

        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public Product GetById(int id)
        {
          return serviceGeneric.GetById(id);
            
        }
        public List<Product> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<Product> GetByName(string name)
        {
            return Context.products.Where(b => b.Name == name).ToList();
        }
    }
}