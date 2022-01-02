using DataAccess.Dto;
using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface IAttributeService
    {
        void Insert(Attribute attribute);
        void Update(Attribute attribute);
        void Delete(int id);
        Attribute GetById(int id);
        List<Attribute> GetAll();
        List<AttributeDto> GetByName(string name);
        List<AttributeDto> GetAttributeDto();

    }
}