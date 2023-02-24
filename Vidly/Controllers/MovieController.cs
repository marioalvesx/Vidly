using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movie = new Movie()
            { Name = "Shrek!"};

            var customers = new List<Customer> 
            {                 
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            { 
                Movie = movie,
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
