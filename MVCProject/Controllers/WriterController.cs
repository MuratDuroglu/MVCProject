using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
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
    }
}