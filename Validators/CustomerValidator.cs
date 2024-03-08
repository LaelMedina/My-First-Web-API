using myFirstWebAPI.Models;
using myFirstWebAPI.Services;

namespace myFirstWebAPI.Validators
{
    public class CustomerValidator : ICustomerService
    {
        public Customer? GetCustomerById(List<Customer> CustomerList, int Id)
        {
            return CustomerList.FirstOrDefault(Customer => Customer.Id == Id);
        }

        public List<Customer>? GetCustomerByName(List<Customer> CustomerList, string nameSearched)
        {
            return CustomerList.Where(customer => customer.Name.ToLower().Contains(nameSearched.ToLower())).ToList();
        }
    }
}
