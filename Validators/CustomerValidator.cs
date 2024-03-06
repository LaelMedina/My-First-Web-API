using myFirstWebAPI.Models;

namespace myFirstWebAPI.Validators
{
    public class CustomerValidator
    {
        public static Customer? ValidateExistingId(List<Customer> CustomerList, int Id)
        {
            return CustomerList.FirstOrDefault(Customer => Customer.Id == Id);
        }

        public static List<Customer>? ValidateExistingName(List<Customer> CustomerList, string nameSearched)
        {
            return CustomerList.Where(customer => customer.Name.ToLower().Contains(nameSearched.ToLower())).ToList();
        }
    }
}
