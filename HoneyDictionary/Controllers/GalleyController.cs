using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HoneyDictionary.Controllers
{
    public class GalleyController : Controller
    {
        ImageFileManager imageFileManager = new ImageFileManager(new GenericRepository<ImageFile>());
        // GET: Galley
        public ActionResult Index()
        {
            var imageFileValue = imageFileManager.GetList();
            return View(imageFileValue);
        }
    }
}