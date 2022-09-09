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

        CategoryValidator categoryvalidator = new CategoryValidator();

        public ActionResult Index()
        {
            var categorylist = categorymanager.GetAll();

            return View(categorylist);
        }


        [HttpGet]

        public ActionResult AddCategory()
        {

            return View();

        }


        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
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

        public ActionResult categorydelete(int Id)
        {
            var willdelete = categorymanager.Get(Id);
            categorymanager.Delete(willdelete);



            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult categoryupdate(int Id)
        {
            var c = Convert.ToInt32(Id);
            var willupdate = categorymanager.Get(c);

            return View(willupdate);

        }
        [HttpPost]
        public ActionResult categoryupdate(Category category)
        {
            categorymanager.CategoryUpdate(category);

            return RedirectToAction("Index");


                } }

    }




