using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projektuppgift___Grupp_K.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: Movie 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}