using BusinessLayer;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryManager aa = new CategoryManager(new EfCategoryDal());
          
            var n = aa.Get(3);
            var CC = aa.GetAll();
            return View(CC);
        }


    }
}