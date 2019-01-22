using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoScape.Models;


namespace PhotoScape.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store/
        public ActionResult Index()
        {
            var categories = new List<Category>
            {
                new Category { Name = "Abstract"},
                new Category { Name = "Animals"},
                new Category { Name = "Nature"}

            };

            //Contract.Ensures(Contract.Result<IActionResult>() != null);
            return View(categories);

        }
         //GET: /Store/Browse

        public ActionResult Browse(string category)
        {

            var CategoryModel = new Category { Name = category };

            return View(CategoryModel);

        }


        // GET: /Store/Details/

        public ActionResult Details(int id)
        {

            var photo = new Photo { Name = "Photo " + id };

            return View(photo);
        }

        // GET: /Store/Abstract/
        public ActionResult Abstract()
        {
          return View();
        }

        // GET: /Store/Nature/
        public ActionResult Nature()
        {
          return View();
        }

        // GET: /Store/Animals/
        public ActionResult Animals()
        {
          return View();
        }

        // GET: /Store/Cart/
        [Authorize]
        public IActionResult Cart()
        {
          return View();
        }

  }
}
