using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.MvcPagerDemo.Models;


namespace VideoWebDemo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult VideoList(int id = 1)
        {
            return View(DemoData.AllArticles.OrderByDescending(a => a.PubDate).ToPagedList(id, 5));
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}