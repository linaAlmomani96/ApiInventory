using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.SpecificRepostory
{
  public class BrandService: IBrandService
    {
        IServiceGeneric<Brand> serviceGeneric;
        InventoryContext Context;
       public BrandService(IServiceGeneric<Brand> _serviceGeneric, InventoryContext _Context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _Context;
        }

        public void Insert(Brand brand)
        {
            serviceGeneric.Insert(brand);
        }
        public void Update(Brand brand)
        {
            serviceGeneric.Update(brand);
        }
        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public Brand GetById(int id)
        {
            Brand brand = serviceGeneric.GetById(id);
            return brand;
        }
        public List<Brand> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<Brand> GetByName(string name)
        {
           return Context.brands.Where(b => b.Name == name).ToList();
        }
    }
}
