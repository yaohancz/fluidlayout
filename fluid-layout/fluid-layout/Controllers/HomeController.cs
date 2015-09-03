using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fluid_layout.Models;

namespace fluid_layout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FluidModels model = new FluidModels();
            model.SignUpText = "SIGN UP FOR DEALS,\r\nLATEST NEWS & MORE";

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string email)
        {
            FluidModels model = new FluidModels();
            model.SignUpText = "SIGN UP FOR DEALS,\r\nLATEST NEWS & MORE";
            model.Email = email;

            return View(model);
        }
    }
}
