using Vidly.Models;

namespace Vidly.ViewModels
{
    public class IndexCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
