using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MvcMusicStore.Models;


namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store/
        public IActionResult Index()
        {
            //Contract.Ensures(Contract.Result<IActionResult>() != null);
            ViewData["Message"] = "Hello from Store.Index()";
            return View();

        }

        /* GET: /Store/Browse
        //public ActionResult Browse(string genre)
        {

            //var genreModel (genreModel);

            //return "Hello from Store.Browse()";
        }
        */

        // GET: /Store/Details/

        public ActionResult Details(int id)
        {

            var album = new Album { Title = "Album " + id };

            return View(album);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


    }
}
