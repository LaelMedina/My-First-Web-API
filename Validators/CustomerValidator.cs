using myFirstWebAPI.Models;

namespace myFirstWebAPI.Validators
{
    public class CustomerValidator
    {
        public static Customer? ValidateExistingId(List<Customer> CustomerList, int Id)
        {
            return CustomerList.FirstOrDefault(Customer => Customer.Id == Id);
        }
    }
}
