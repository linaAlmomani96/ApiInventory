using Business.SpecificRepostory;
using DataAccess.Dto;
using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
      private readonly  IAttributeService attributeService;
        public AttributeController(IAttributeService _attributeService)
        {
            attributeService = _attributeService;
        }
        [HttpPost]
        public ActionResult Insert(Attribute attribute)
        {
            attributeService.Insert(attribute);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Attribute attribute)
        {
            attributeService.Update(attribute);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            attributeService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Attribute> GetAll()
        {
            return attributeService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Attribute GetById(int id)
        {
            return attributeService.GetById(id);

        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<AttributeDto > GetByName(string name)
        {
            return attributeService.GetByName(name);
        }
        [HttpGet]
        [Route("CountAtribute")]

        public List<AttributeDto> GetAttributeDto()
        {
            return attributeService.GetAttributeDto();
        }
      
    }
}
