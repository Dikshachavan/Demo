using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using Diksha.Models;
using Diksha.ViewModel;

namespace Diksha.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult DisplayMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{ Name="Sanam Teri Kasam" },
                new Movie{Name="Taqdeer"}

            };
            return View(movies.ToList());
        }
        // GET: Movie
        public ViewResult Index()
        {
            var Movie = new Movie()
            {
                Name = "Sanam teri kasam.."                
            };
            var customers = new List<Customer>
            {
                new Customer{ID=1, Name="Diksha"},
                new Customer{ID=2,Name="Ravina"}
            };
            var ViewModal = new CustomerandMovieViewModel
            {
                Customer = customers,
                Movie = Movie
            };
            return View(ViewModal);
        }
        public ActionResult Edit(string id)
        {
            return Content("ID:"+ id);
        }
        public ActionResult Index1(int? PageIndex, string SortBY)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (string.IsNullOrWhiteSpace(SortBY))
                SortBY = "Name";
            
            string numStr = String.Format("Number {0, 0:C2}", PageIndex);
            return Content(string.Format("PageIndex:{0} SortBy:{1} something:{2}",PageIndex,SortBY, numStr));
        }
    }
}