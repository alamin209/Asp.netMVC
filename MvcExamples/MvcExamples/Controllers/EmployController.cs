using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcExamples.Models;

namespace MvcExamples.Controllers
{
    public class EmployController : Controller
    {
        // Part 7 done Here 
        //public ActionResult Details()
        //{
        //    Employ employ = new Employ()

        //    {
        //        EmployId=13,
        //         Name= "alamin",
        //        City="Dhaka",
        //        Gender="Male"

        //    };


        //    return View(employ);
        //}

        //part 8
        public ActionResult Details(int id)
        {

            EmployeContext employeContext = new EmployeContext();
            Employ employ = employeContext.Employs.Single(emp => emp.EmployID == id);

     
            return View(employ);
        }

    }
}