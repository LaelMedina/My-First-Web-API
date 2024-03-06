using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myFirstWebAPI.Models;
using myFirstWebAPI.Validators;
using System.Text.Json;

namespace myFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        List<Customer> CustomerList = new List<Customer>()
        {
            new() {Id = 0, Name = "Eren Jaeger"},

            new() {Id = 1, Name = "Mikasa Ackerman"},
            
            new() {Id = 2, Name = "Armin Arlert"}
        };

        [HttpGet("list")]
        public string getCustomersList()
        {
            return JsonSerializer.Serialize(CustomerList);
        }

        [HttpGet("{id}")]
        public IActionResult getCustomerById(int Id)
        {
            Customer? customer = CustomerValidator.ValidateExistingId(CustomerList, Id);

            if (customer != null)
            {
                return Ok(customer);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
