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
    public class CategoryController : ControllerBase
    {
       private  readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [HttpPost]
        public ActionResult Insert(Category category)
        {
            categoryService.Insert(category);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Category category)
        {
            categoryService.Update(category);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            categoryService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Category GetById(int id)
        {
            return  categoryService.GetById(id);
           
        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<Category> GetByName(string name)
        {
            return categoryService.GetByName(name);
        }
    }
}
