using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myFirstWebAPI.Models;
using myFirstWebAPI.Services;
using myFirstWebAPI.Validators;
using System.Text.Json;

namespace myFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerValidator;

        public CustomerController(ICustomerService customerValidator)
        {
            _customerValidator = customerValidator;
        }

        List<Customer> CustomerList = new List<Customer>()
        {
            new() {Id = 0, Name = "Eren Jaeger"},

            new() {Id = 1, Name = "Mikasa Ackerman"},
            
            new() {Id = 2, Name = "Armin Arlert"}
        };


        [HttpGet("list")]
        public ActionResult GetCustomersList()
        {
            return Ok(CustomerList);
        }

        [HttpGet("{id}")]
        public ActionResult GetCustomerById(int Id)
        {
            Customer? customer = _customerValidator.GetCustomerById(CustomerList, Id);

            if (customer != null)
            {
                return Ok(customer);
            }
            
            return NotFound();
        }

        [HttpGet("search/{nameSearched}")]
        public ActionResult GetCustomerByName(string nameSearched)
        {
            List<Customer>? customer = _customerValidator.GetCustomerByName(CustomerList, nameSearched);
            
            if(customer != null){
                return Ok(customer);
            }

            return NotFound();
        }
    }
}
