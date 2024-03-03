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
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new GenericRepository<Content>());
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentValue = cm.GetList().Where(x => x.HeadingID == id).ToList();
            return View(contentValue);
        }
    }
}