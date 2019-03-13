using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Movie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        // GET: HelloWorld/Welcome/
        public ActionResult Welcome(string nom, int numTimes = 1)
        {
            ViewBag.Message = "Bonjour" + nom;
            ViewBag.NumTimes = numTimes;
            return View();
        }
       
    }
}