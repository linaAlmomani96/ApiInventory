using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class AttributeValueService:IAttributeValueService
    {
        IServiceGeneric<AttributeValue> serviceGeneric;
        InventoryContext Context;
        public AttributeValueService(IServiceGeneric<AttributeValue> _serviceGeneric, InventoryContext _Context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _Context;
        }

        public void Insert(AttributeValue attributeValue)
        {
            serviceGeneric.Insert(attributeValue);
        }
        public void Update(AttributeValue attributeValue)
        {
            serviceGeneric.Update(attributeValue);
        }
        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public AttributeValue GetById(int id)
        {
            return  serviceGeneric.GetById(id);
        }
        public List<AttributeValue> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<AttributeValue> GetByName(string name)
        {
            return Context.attributeValues.Where(b => b.Name == name).ToList();
        }

       public List<AttributeValue> GetAttrValues(int id)
        {
           return Context.attributeValues.Where(a => a.Attribute_Id == id).ToList();
        }

        public List<AttributeValue> GetAllColors()
        {
            return Context.attributeValues.Where(a => a.Attribute_Id == 6).ToList();
        }

        public List<AttributeValue> GetAllSize()
        {
            return Context.attributeValues.Where(a => a.Attribute_Id == 5).ToList();
        }
    }
}