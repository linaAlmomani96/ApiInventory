using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface IOrderService
    {
        void Insert(Order order);
        void Update(Order order);
        void Delete(int id);
        Order GetById(int id);
        List<Order> GetAll();
        List<Order> GetByName(string name);
    }
}