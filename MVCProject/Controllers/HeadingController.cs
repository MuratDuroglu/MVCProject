using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heding
        HeadingManager _manager = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            

            var headinglist = _manager.GetAll();

            //var beklenilen = headinglist.FirstOrDefault().Category.CategoryName;
            return View(headinglist);
        }
    }
}