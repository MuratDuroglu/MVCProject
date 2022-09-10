using BusinessLayer.Concreate;
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
    public class WriterController : Controller
    {
        // GET: Writer

        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
           var a= wm.GetList();

            return View(a);
        }


        [HttpGet]

        public ActionResult AddWriter()
        {

            return View();
        }



        [HttpPost] 
        public ActionResult AddWriter(Writer p)
        {
            WriterValidator _writervalid = new WriterValidator();

            ValidationResult results = _writervalid.Validate(p);


            if (results.IsValid)
            {

                wm.WriterAdd(p);
            }
            else
            {

                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult EditWriter(int Id)
        {

            var gelenwrite = wm.GetById(Id);



            return View(gelenwrite);

        }

        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {

            WriterValidator _writervalid = new WriterValidator();

            ValidationResult results = _writervalid.Validate(p);


            if (results.IsValid)
            {

                wm.WriterUpdate(p);

                return RedirectToAction("Index");
            }
            else
            {

                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View(p);
          

        }





    }
}