using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class CategoryService:ICategoryService
    {
        IServiceGeneric<Category> serviceGeneric;
        InventoryContext Context;
        public CategoryService(IServiceGeneric<Category> _serviceGeneric, InventoryContext _Context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _Context;
        }

        public void Insert(Category category)
        {
            serviceGeneric.Insert(category);
        }
        public void Update(Category category)
        {
            serviceGeneric.Update(category);
        }
        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public Category GetById(int id)
        {
            Category category = serviceGeneric.GetById(id);
            return category;
        }
        public List<Category> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<Category> GetByName(string name)
        {
            return Context.categories.Where(b => b.Name == name).ToList();
        }
    }
}