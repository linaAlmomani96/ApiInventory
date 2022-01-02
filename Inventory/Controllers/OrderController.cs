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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }
        [HttpPost]
        public ActionResult Insert(Order order)
        {
            orderService.Insert(order);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Order order)
        {
            orderService.Update(order);
            return StatusCode(StatusCodes.Status200OK);

        }
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            orderService.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Order> GetAll()
        {
            return orderService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Order GetById(int id)
        {
            return orderService.GetById(id);

        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public List<Order> GetByName(string name)
        {
            return orderService.GetByName(name);
        }
    }
}
