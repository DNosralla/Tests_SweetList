using SweetList.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetList.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(SweetList.Entity.SweetListDbContext dbContext)
        {
        }
        

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
