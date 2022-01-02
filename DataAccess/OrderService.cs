using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class OrderService:IOrderService
    {

        IServiceGeneric<Order> serviceGeneric;
        InventoryContext Context;
        public OrderService(IServiceGeneric<Order> _serviceGeneric, InventoryContext _Context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _Context;
        }

        public void Insert(Order order)
        {
            serviceGeneric.Insert(order);
        }
        public void Update(Order order)
        {
            serviceGeneric.Update(order);
        }
        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public Order GetById(int id)
        {
           return serviceGeneric.GetById(id);
        
        }
        public List<Order> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<Order> GetByName(string name)
        {
            return Context.orders.Where(b => b.CustomerName == name).ToList();
        }
    }
}