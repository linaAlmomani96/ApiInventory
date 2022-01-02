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
    public class StoreController : ControllerBase
    {
       private  readonly IStoreService storeService;
        public StoreController(IStoreService _storeService)
        {
            storeService = _storeService;
        }

        [HttpPost]
        public ActionResult Insert(Store store)
        {
            storeService.Insert(store);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Store Store)
        {
            storeService.Update(Store);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            storeService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Store> GetAll()
        {
            return storeService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Store GetById(int id)
        {
            return storeService.GetById(id);

        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<Store> GetByName(string name)
        {
            return storeService.GetByName(name);
        }
    }
}
