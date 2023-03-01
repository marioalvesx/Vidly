using Microsoft.AspNetCore.Mvc;
using Vidly.Persistence;
using Microsoft.EntityFrameworkCore;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private VidlyDbContext _context;

        public CustomerController(VidlyDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include( c => c.MembershipType );
            var viewModel = new IndexCustomer
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }            
    }
}
