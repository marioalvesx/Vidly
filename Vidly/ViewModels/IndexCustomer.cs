using Vidly.Models;

namespace Vidly.ViewModels
{
    public class IndexCustomer
    {
        public Customer Customer { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}
