using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customerName = new Customer()
            {
                Name = "Test"
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Robert" },
                new Customer { Name = "Leonardo" }
            };

            var viewModel = new IndexCustomerViewModel
            { 
                Customer = customerName,
                Customers = customers 
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}
