using Poject_Photo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poject_Photo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private WebPhotoContext db;
        public HomeController()
        {
            db = new WebPhotoContext();
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}