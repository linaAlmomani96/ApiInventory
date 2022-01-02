using DataAccess.Context;
using DataAccess.Dto;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class AttributeService : IAttributeService
    {
        IServiceGeneric<Attribute> serviceGeneric;
        InventoryContext Context;
        public AttributeService(IServiceGeneric<Attribute> _serviceGeneric, InventoryContext _Context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _Context;
        }

        public void Insert(Attribute attribute)
        {
            serviceGeneric.Insert(attribute);
        }
        public void Update(Attribute attribute)
        {
            serviceGeneric.Update(attribute);
        }
        public void Delete(int id)
        {
            serviceGeneric.Delete(id);

        }

        public Attribute GetById(int id)
        {
            Attribute attribute = serviceGeneric.GetById(id);
            return attribute;
        }
        public List<Attribute> GetAll()
        {
            return serviceGeneric.GetAll();
        }

        public List<AttributeDto> GetByName(string name)
        {
            return Context.attributes.Where(b => b.Name == name).Select(attr => new AttributeDto()
            {
                Id = attr.Id,
                AttributeName = attr.Name,
                AttributeNameCount = attr.attributeValues.Count(),
                Status = attr.Status
            }).ToList();
        }

        public List<AttributeDto> GetAttributeDto()
        {

            List<AttributeDto> attributes = Context.attributes.Select(attr => new AttributeDto() { 
                                                                       Id = attr.Id,
                                                                       AttributeName = attr.Name,
                                                                       AttributeNameCount = attr.attributeValues.Count(),
                                                                       Status = attr.Status
                                                                   }).ToList();
            return attributes;
        }

     

    }
}