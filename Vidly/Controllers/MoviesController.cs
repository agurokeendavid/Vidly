using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var model = new Movie()
            {
                Name = "Shrek!"
            };
            return View(model);
            
        }


        [Route(@"movies/released/{year}/{month:regex(\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}