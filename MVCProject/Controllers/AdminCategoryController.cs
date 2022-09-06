using BusinessLayer;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categorymanager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categorylist = categorymanager.GetAll();

            return View(categorylist);
        }

       
        public ActionResult AddCategory(Category category)
        {
            

            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult result = categoryvalidator.Validate(category);
            if (result.IsValid)
            {
                categorymanager.Add(category);
                return RedirectToAction("Index");
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

    }
}