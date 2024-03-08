using myFirstWebAPI.Models;

namespace myFirstWebAPI.Services
{
    public interface ICustomerService
    {
        Customer? GetCustomerById(List<Customer> CustomerList,int customerId);

        List<Customer>? GetCustomerByName(List<Customer> CustomerList,string customerName);
    }
}
