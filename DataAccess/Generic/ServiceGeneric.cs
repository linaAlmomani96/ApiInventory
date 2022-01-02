using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Generic
{
   public class ServiceGeneric<T>:IServiceGeneric<T> where T:class
    {
      private readonly InventoryContext context;
         public  ServiceGeneric(InventoryContext _context)
           {
            context = _context;
           }
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = EntityState.Modified;//state
            context.SaveChanges();
        }

        public void Delete(int id)
        {
           T obj = context.Set<T>().Find(id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();

        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
