using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExamples.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.county = new List<string>
 
            //ViewData["country"]= new List<string>() //VIew  Date Example
            {
                "bangldesh",
                "uk",
                "srilanka"
            };

            return View();

           


        }

       

        
    }
}