using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Customer> _customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "Tamer Fouad"},
            new Customer {Id = 2, Name = "Mahmoud Awad"}
        };

        private List<Movie> _movies = new List<Movie>
        {
            new Movie {Id = 1, Name = "Shrek!"},
            new Movie {Id = 2, Name = "Die Hard"}
        };

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            _customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
                new Customer {Name = "Customer 3"},
                //new Customer {Name = "Customer 4"},
                //new Customer {Name = "Customer 5"},
                //new Customer {Name = "Customer 6"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = _customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }

        public ActionResult Index()
        {
            return View(_movies);
        }

        [Route("movies/released/{year:regex(2016|2017)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"year = { year }, month = '{ month }'");
        }

        public ActionResult Customers()
        {
            return View(_customers);
        }

        [Route("movies/customers/details/{id:range(1,2)}")]
        public ActionResult CustomerDetails(int id)
        {
            Customer customer = _customers.Find(c => c.Id == id);
            return View(customer);
        }
    }
}