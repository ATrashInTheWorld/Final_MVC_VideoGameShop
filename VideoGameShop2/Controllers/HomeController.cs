using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VideoGameShop2.Models;

namespace VideoGameShop.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        private VideoGameShop2DB db = new VideoGameShop2DB();

        public ActionResult Index()
        {

                var mostRecent = (from p in db.Products
                                      orderby p.productISBN descending
                                      select p).ToList();

            Session["items"] = mostRecent;
                return View(mostRecent);
        }

        public ActionResult AboutContactUs()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LoginandRegister()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult _Login()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult _Register()
        {
            return View("LoginandRegister");
        }
    }
}