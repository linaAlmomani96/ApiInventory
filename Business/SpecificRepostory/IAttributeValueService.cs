using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface IAttributeValueService
    {
        void Insert(AttributeValue attributeValue);
        void Update(AttributeValue attributeValue);
        void Delete(int id);
        AttributeValue GetById(int id);
        List<AttributeValue> GetAll();
        List<AttributeValue> GetByName(string name);
        List<AttributeValue> GetAttrValues(int id);
        List<AttributeValue> GetAllColors();
        List<AttributeValue> GetAllSize();
    }

}