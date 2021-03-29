using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Postoffice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
		public ActionResult About()
		{
			return View();
		}
		public ActionResult Contact()
		{
			return View();
		}
		public ActionResult Shipping()
		{
			return View();
		}
		public ActionResult Track()
		{
			return View();
		}
		public ActionResult Head()
		{
			return View();
		}
		public ActionResult Employee()
		{
			return View();
		}
		public ActionResult Customer()
		{
			return View();
		}
	}
}