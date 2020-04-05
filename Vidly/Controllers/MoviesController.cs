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

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";


            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
    }
}