using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Service.Context;

using Service.Customer;

namespace Desafio.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var _return = _customerService.GetAll();
            if (_return.Count<=0 ){
                _customerService.Save(new Customer { Name = "Gesualdo", Email="gesualdo.crocco@gmail.com" });
                return Ok( "Desafio Dell");
            }
            return Ok(_return);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var customer = _customerService.GetById(id);

            if (customer == null)
            {                
                return NotFound($"Id {id} Not Found");
            }

            return Ok(_customerService.GetById(id));
        }

        public IActionResult Post([FromForm]Customer customer)
        {
            try
            {
                _customerService.Save(customer);
                return Ok(customer);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }

        }

        [HttpPut()]
        public IActionResult Put( [FromForm]Customer customer)
        {
            try
            {
                _customerService.Save(customer);
                return Ok(customer);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }

        }



    }
}