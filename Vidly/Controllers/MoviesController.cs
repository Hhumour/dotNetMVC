using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/ Random
        public IActionResult Random()// ActionResult has many subtypes i.e. ViewResult, PartialViewResult, ContentResult, etc.
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1"},
                new Customer {Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model
            /*return Content("Hello World");
            return HttpNotFound();
            return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });*/
            return View(viewModel);

        }
        
        
        /*[Route("movies/released/{year}/{month}")]//[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
                
        }

        // GET: Movies/Edit/1   OR    GET:Movies/Edit?id=1
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //GET: Movies
        public IActionResult Index(int? pageIndex, string sortBy) // '?' is used to make it nullable, But string is by default nullable
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy)){
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&&sortBy={1}", pageIndex, sortBy));
        }*/

    }
}