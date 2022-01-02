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
    public class BrandController : ControllerBase
    {
       private readonly IBrandService brandService;
        public BrandController(IBrandService _brandService)
        {
            brandService = _brandService;
        }
        [HttpPost]
        public ActionResult Insert(Brand brand)
        {
            brandService.Insert(brand);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Brand brand)
        {
            brandService.Update(brand);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            brandService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Brand> GetAll()
        {
            return brandService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Brand GetById(int id)
        {
            Brand brand = brandService.GetById(id);
            return brand;
        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<Brand> GetByName(string name)
        {
            return brandService.GetByName(name);
        }
    }
}
