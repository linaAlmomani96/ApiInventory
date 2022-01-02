using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface ICategoryService
    {
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        Category GetById(int id);
        List<Category> GetAll();
        List<Category> GetByName(string name);
    }
}