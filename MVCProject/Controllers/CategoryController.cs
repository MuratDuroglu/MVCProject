using BusinessLayer;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager _cmanager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            CategoryManager aa = new CategoryManager(new EfCategoryDal());

            var n = aa.Get(3);
            var CC = aa.GetAll();
            return View(CC);

        }
        public ActionResult CategoryList()
        {
           
            var listcategory = _cmanager.GetAll();

            return View(listcategory);
        }

        [HttpPost]
        public ActionResult AddNewCategory(Category _category)
        {
            CategoryManager _cmanager = new CategoryManager(new EfCategoryDal());

            CategoryValidator _categoryvalidator = new CategoryValidator();

            ValidationResult result = _categoryvalidator.Validate(_category);
            if (result.IsValid)
            {
                _cmanager.Add(_category);

                return RedirectToAction("CategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }

            return View();

        }
        [HttpGet]
        public ActionResult AddNewCategory()
        {

            return View();

        }


    }
}