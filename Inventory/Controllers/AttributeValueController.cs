using Business.SpecificRepostory;
using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeValueController : ControllerBase
    {
       private readonly IAttributeValueService attributeValueService;
        public AttributeValueController(IAttributeValueService _attributeValueService)
        {
            attributeValueService = _attributeValueService; ;
        }
        [HttpPost]
        public ActionResult Insert(AttributeValue attributeValue)
        {
            attributeValueService.Insert(attributeValue);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(AttributeValue attributeValue)
        {
            attributeValueService.Update(attributeValue);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            attributeValueService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        //[HttpGet]
        //[Route("GetAll")]
        //[Route("test")]
        //public List<AttributeValue> GetAll()
        //{
        //    return attributeValueService.GetAll();
        //}
        [HttpGet]
        [Route("GetById/{id}")]
        public AttributeValue GetById(int id)
        {
            return attributeValueService.GetById(id);

        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<AttributeValue> GetByName(string name)
        {
            return attributeValueService.GetByName(name);
        }

        [HttpGet]
        [Route("GetAttrValues/{id}")]
        public List<AttributeValue> GetAttrValues(int id)
        {
            return attributeValueService.GetAttrValues(id);
        }
        [HttpGet]
        [Route("GetAllColors")]
         public List<AttributeValue> GetAllColors()
        {
            return attributeValueService.GetAllColors();
        }
        [HttpGet]
        [Route("GetAllSize")]
        public List<AttributeValue> GetAllSize()
        {
            return attributeValueService.GetAllSize();
        }


    }
}
