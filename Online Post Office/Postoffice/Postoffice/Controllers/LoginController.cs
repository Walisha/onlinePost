using Postoffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Postoffice.Controllers
{
    public class LoginController : Controller
    {
		private PostOfficeDBEntities db = new PostOfficeDBEntities();
		// GET: Login
		public ActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Index(Customer cus,string ReturnUrl)
		{
            var login = db.Customer.Where(a => a.Email == cus.Email && a.Password == cus.Password).FirstOrDefault();
            if (login != null)
            {
                FormsAuthentication.SetAuthCookie(login.Name, false);
                Session["role"] = login.Role;
                Session["name"] = login.Name;
                Session["id"] = login.Id;


                if (Session["role"].ToString() == "Head")
                {
                    if (ReturnUrl != null)
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Head","Home");
                    }
                }
                else if (Session["role"].ToString() == "Employee")
                {
                    if (ReturnUrl != null)
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Employee","Home");
                    }
                }
                else if (Session["role"].ToString() == "Customer")
                {
                    if (ReturnUrl != null)
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Customer","Home");
                    }
                }
            }
            else
            {
                ViewBag.msg = "<script>alert('Invalid Credentials');</script>";
                return View();
            }
            return View();

        }

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			Session.Abandon();
			return RedirectToAction("Index","Home");
		}
		
	}
}