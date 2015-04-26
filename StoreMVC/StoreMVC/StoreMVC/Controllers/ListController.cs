using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class ListController : Controller
    {
        private ProductDBContext de = new ProductDBContext();
        public ActionResult Index()
        {
            ViewBag.listProducts = de.Products.ToList();
            return View();
        }

    }
}
