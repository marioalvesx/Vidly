using Microsoft.AspNetCore.Mvc;
using Vidly.Persistence;
using Microsoft.EntityFrameworkCore;
using Vidly.ViewModels;
using Vidly.Models;

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
            var customers = _context.Customers.Include(c => c.MembershipType);
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new IndexCustomer
            {
                Customers = customers,
                MembershipTypes = membershipTypes
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

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        [HttpPut("{id}")]
        public ActionResult Update(Customer customer)
        {
            if(customer.Id != 0)
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            } // Apply DTO here.

            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

    }
}
