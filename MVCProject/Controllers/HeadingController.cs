using BusinessLayer;
using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace MVCProject.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heding
        HeadingManager _hmanager = new HeadingManager(new EfHeadingDal());
        WriterManager _wmanager = new WriterManager(new EfWriterDal());
        CategoryManager _cmanager = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var headinglist = _hmanager.GetAll();





            //var result = (from x in _hmanager.GetAll()
            //              join y in _cmanager.GetAll() 
            //              on
            //              x.CategoryId equals y.CategoryId
                      
            //              select new
            //              {
            //                  HeadingId=x.HeadingId,
            //                  HeadingName=x.HeadingName,
            //                  HeadingDate=x.HeadingDate,
            //                  CategoryId=y.CategoryName,
            //                  WriterId = x.WriterId
                          
            //              }).ToList();
         
           
            return View(headinglist);

        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate =DateTime.Parse( DateTime.Now.ToShortDateString());
            HeadingValidator _validator = new HeadingValidator();

            ValidationResult result = _validator.Validate(heading);
            if (result.IsValid)
            {

                _hmanager.Add(heading);
            }



            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult AddHeading()
        {

            List<SelectListItem> valuecategory = (from x in _cmanager.GetAll() select new SelectListItem { Text=x.CategoryName,
            
            Value=x.CategoryId.ToString()
            }).ToList();

            ViewBag.vlc = valuecategory;


            return View();

        }
    }



}