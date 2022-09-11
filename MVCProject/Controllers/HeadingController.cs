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
namespace MVCProject.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heding
        HeadingManager _hmanager = new HeadingManager(new EfHeadingDal());


        CategoryManager _cmanager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var headinglist = _hmanager.GetAll();

            using (var db = new ProjectContext())
            {

                var model = db.Headings.Include(x => x.Category).ToList();



                //var result = (from x in _hmanager.GetAll()
                //              join y in _cmanager.GetAll() on x.CategoryId equals y.CategoryId
                //              select new
                //              {
                //                  x.HeadingId,
                //                  x.HeadingName,
                //                  x.HeadingDate,
                //                  y.CategoryId,
                //                  y.CategoryName

                //              }).ToList();

                
                return View(model);
            }
        }
    }
}