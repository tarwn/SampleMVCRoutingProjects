using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC3Project.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Other()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Redirect()
        {
            return View("Other");
        }

    }
}
