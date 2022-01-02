using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class StoreService:IStoreService
    {
        IServiceGeneric<Store> serviceGeneric;
        InventoryContext context;
        public StoreService(IServiceGeneric<Store> _serviceGeneric, InventoryContext _context)
        {
            serviceGeneric = _serviceGeneric;
            context = _context;
        }

        public void Insert(Store store)
        {
            serviceGeneric.Insert(store);
        }

        public void Update(Store store)
        {
            serviceGeneric.Update(store);
        }
        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public Store GetById(int id)
        {
            return serviceGeneric.GetById(id);
            
        }
        public List<Store> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<Store> GetByName(string name)
        {
            return context.stores.Where(b => b.Name == name).ToList();
        }
    }
}