using MondayGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MondayGrid.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities _northwindEntities;
        public CategoryController()
        {
            _northwindEntities = new NorthwindEntities();
        }
        
        public ActionResult ProductList()
        {
            var model = _northwindEntities.Products.ToList();
            return View(model);
        }
    }
}