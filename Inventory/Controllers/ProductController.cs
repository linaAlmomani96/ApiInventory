using Business.SpecificRepostory;
using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        [HttpPost]
        public ActionResult Insert(Product product)
        {
            if (product.filePath !=null )
            {  
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),@"DataAccess\Images", product.filePath.FileName);

                product.filePath.CopyTo(new FileStream(filePath, FileMode.Create));

                product.ImgPhoto = "http://localhost/Task1MVC/" + "Imgaes" + '\\' + product.filePath.FileName;
            }
            productService.Insert(product);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Product product)
        {
            productService.Update(product);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            productService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Product GetById(int id)
        {
            return productService.GetById(id);

        }
        
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<Product> GetByName(string name)
        {
            return productService.GetByName(name);
        }



    }
}
